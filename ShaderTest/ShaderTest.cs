using TimberApi.ConsoleSystem;
using TimberApi.ModSystem;

namespace ShaderTest;

public class ShaderTest : IModEntrypoint
{
    public static IConsoleWriter ConsoleWriter;

    public void Entry(IMod mod, IConsoleWriter consoleWriter)
    {
        ConsoleWriter = consoleWriter;
        consoleWriter.LogInfo($"Loaded Testmod for Timberborn {TimberApi.Versions.GameVersion}");
    }
}