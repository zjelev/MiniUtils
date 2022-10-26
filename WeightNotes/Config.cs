using System.Text.Json;

public class Config
{
    internal static string logPath = Environment.CurrentDirectory + Path.DirectorySeparatorChar + "AvtoveznaMonthly" + Path.DirectorySeparatorChar;
    private static string config = File.ReadAllText(logPath + "config.json");
    internal static string veznaHost = JsonSerializer.Deserialize<Config>(config).Vezna.Host;
    internal static string veznaPath = JsonSerializer.Deserialize<Config>(config).Vezna.Path;
    internal static string veznaFilePattern = JsonSerializer.Deserialize<Config>(config).Vezna.File;
    internal static string clientInfo = JsonSerializer.Deserialize<Config>(config).Speditor.StaticInfo;
    internal static TimeSpan startShift = new TimeSpan(8, 00, 0);
    internal static TimeSpan endShift = new TimeSpan(20, 00, 0);

    public Vezna Vezna { get; set; }
    public Speditor Speditor { get; set; }

}

public class Vezna
{
    public string Host { get; set; }
    public string Path { get; set; }
    public string File { get; set; }
}

public class Speditor
{
    public string File { get; set; }
    public string Email { get; set; }
    public string StaticInfo { get; set; }
}