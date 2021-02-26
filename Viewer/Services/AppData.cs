namespace Viewer.Services
{
    public class AppData
    {
        public bool IsLocalDev { get; set; }
        public string SettingsPath { get; set; } = "config/settings.json";
    }
}