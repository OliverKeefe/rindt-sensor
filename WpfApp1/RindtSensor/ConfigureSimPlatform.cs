using System.Runtime.Versioning;

namespace RindtSensor;

public class ConfigureSimPlatform
{
    private string _platform;

    public ConfigureSimPlatform(string platform)
    {
        _platform = platform;
    }
    
    public string SetSimPlatform(string platform)
    {
        return _platform;
    }

    public string getSimPlatform()
    {
        return _platform == "iRacing" ? "iRacing" : _platform == "F1" ? "F1" : null;
    }
    
}