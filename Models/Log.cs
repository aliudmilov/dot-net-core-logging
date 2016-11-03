using System;

namespace log4sky
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime DateWritten { get; set; }
        public string Territory { get; set; }
        public string Proposition { get; set; }
        public string PropositionVersion { get; set; }
        public string Platform { get; set; }
        public string PlatformOs { get; set; }
        public string PlatformOsVersion { get; set; }
        public string Runtime { get; set; }
        public string RuntimeVersion { get; set; }
        public string Level { get; set; }
        public string ErrorType { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorUrl { get; set; }
        public string ErrorContent { get; set; }
        public int ErrorLineNumber { get; set; }
        public string ErrorAdditionalInfo { get; set; }
        public string UserTrackingId { get; set; }
        public bool IsOnline { get; set; }
        public bool IsOutOfLocale { get; set; }
        public bool IsAuthenticated { get; set; }
        public int TotalMemory { get; set; }
        public int TotalDiskSpace { get; set; }
        public int MemoryUsage { get; set; }
        public int CpuUsage { get; set; }
    }
}