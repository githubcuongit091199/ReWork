using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper
{
    public class Settings
    {
        public static IConfiguration Configuration { get; set; }
        public static string GetAppConfig(string val)
        {
            return Configuration.GetValue<string>(val) ?? string.Empty;
        }
        public static string JWT_KEY
        {
            get
            {
                return GetAppConfig("JWT:SecretKey");
            }
        }
        public static string JWT_ISSUE
        {
            get
            {
                return GetAppConfig("JWT:JwtIssuer");
            }
        }
        public static string JWT_EXPI
        {
            get
            {
                return GetAppConfig("JWT:JwtExpireDays");
            }
        }
    }
}
