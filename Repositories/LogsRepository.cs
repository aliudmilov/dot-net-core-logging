using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using System;
using System.Linq;

namespace log4sky
{
    public class LogsRepository : ILogsRepository
    {
        private static string GetQuery =
            @"SELECT 
            id, 
            date_written, 
            territory,
            proposition,
            proposition_version,
            platform,
            platform_os,
            platform_os_version,
            runtime,
            runtime_version,
            level,
            error_type,
            error_code,
            error_url,
            error_content,
            error_line_number,
            error_additional_info,
            user_tracking_id,
            is_online,
            is_out_of_locale,
            is_authenticated,
            total_memory,
            total_disk_space,
            memory_usage,
            cpu_usage
            FROM log4sky.log";
        private static string WhereIdClause = "WHERE id = @id";
        private static string InsertQuery =
            @"INSERT INTO log4sky.log
            (
                date_written, 
                territory, 
                proposition, 
                proposition_version,
                platform,
                platform_os,
                platform_os_version,
                runtime,
                runtime_version,
                level,
                error_type,
                error_code,
                error_url,
                error_content,
                error_line_number,
                error_additional_info,
                user_tracking_id,
                is_online,
                is_out_of_locale,
                is_authenticated,
                total_memory,
                total_disk_space,
                memory_usage,
                cpu_usage
            )
            VALUES
            (
                @DateWritten, 
                @Territory, 
                @Proposition, 
                @PropositionVersion,
                @Platform,
                @PlatformOs,
                @PlatformOsVersion,
                @Runtime,
                @RuntimeVersion,
                @Level,
                @ErrorType,
                @ErrorCode,
                @ErrorUrl,
                @ErrorContent,
                @ErrorLineNumber,
                @ErrorAdditionalInfo,
                @UserTrackingId,
                @IsOnline,
                @IsOutOfLocale,
                @IsAuthenticated,
                @TotalMemory,
                @TotalDiskSpace,
                @MemoryUsage,
                @CpuUsage
            );
            SELECT LAST_INSERT_ID()";
        private static string DeleteQuery = "DELETE FROM log4sky.log";

        public LogsRepository()
        {
        }

        public void Add(Log item)
        {
            using (IDbConnection connection = new MySqlConnection(General.ConnectionString))
            {
                connection.Open();
                item.Id = connection.ExecuteScalar<int>(LogsRepository.InsertQuery, item);
            }
        }

        public Log Get(int id)
        {
            using (IDbConnection connection = new MySqlConnection(General.ConnectionString))
            {
                connection.Open();
                return connection.Query<Log>(
                    LogsRepository.GetQuery +
                    Environment.NewLine +
                    LogsRepository.WhereIdClause, new { @id = id }).FirstOrDefault();
            }
        }

        public IEnumerable<Log> GetAll()
        {
            using (IDbConnection connection = new MySqlConnection(General.ConnectionString))
            {
                connection.Open();
                return connection.Query<Log>(LogsRepository.GetQuery).AsList();
            }
        }

        public void DeleteAll()
        {
            using (IDbConnection connection = new MySqlConnection(General.ConnectionString))
            {
                connection.Open();
                connection.Execute(LogsRepository.DeleteQuery);
            }
        }
    }
}