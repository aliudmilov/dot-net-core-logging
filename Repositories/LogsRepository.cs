using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace log4sky
{
    public class LogsRepository : ILogsRepository
    {
        public LogsRepository()
        {
        }

        public IEnumerable<Log> GetAll()
        {
            using (IDbConnection connection = new MySqlConnection(General.ConnectionString))
            {
                connection.Open();
                return connection.Query<Log>(@"SELECT 
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
                    FROM log4sky.log").AsList();
            }
        }
    }
}