namespace DEM.Project
{
    public class ProjectConsts
    {
        public const string LocalizationSourceName = "Project";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;
    }
    public enum UserHttpCode
    {
        Error = -2,
        ErrorWithLang = -1,
        Success = 0,
        Warning = 1
    }
}
