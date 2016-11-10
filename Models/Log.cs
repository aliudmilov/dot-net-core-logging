using System;
using System.ComponentModel.DataAnnotations;

namespace log4sky
{
    public class Log
    {
        public int Id { get; internal set; }

        public DateTime DateWritten { get; internal set; }

        [Required]
        [MaxLength(4)]
        public string Territory { get; set; }

        [Required]
        [MaxLength(16)]
        public string Proposition { get; set; }

        [Required]
        [MaxLength(16)]
        public string PropositionVersion { get; set; }

        [Required]
        [MaxLength(16)]
        public string Platform { get; set; }

        [Required]
        [MaxLength(16)]
        public string PlatformOs { get; set; }

        [Required]
        [MaxLength(16)]
        public string PlatformOsVersion { get; set; }

        [MaxLength(16)]
        public string Runtime { get; set; }

        [MaxLength(16)]
        public string RuntimeVersion { get; set; }

        [Required]
        [MaxLength(16)]
        public string Level { get; set; }

        [MaxLength(32)]
        public string ErrorType { get; set; }

        [MaxLength(16)]
        public string ErrorCode { get; set; }

        [MaxLength(2048)]
        public string ErrorUrl { get; set; }

        [Required]
        [MaxLength(Int32.MaxValue)]
        public string ErrorContent { get; set; }

        public int ErrorLineNumber { get; set; }

        [MaxLength(Int32.MaxValue)]
        public string ErrorAdditionalInfo { get; set; }

        [MaxLength(48)]
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