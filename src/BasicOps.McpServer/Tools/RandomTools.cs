using System.ComponentModel;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

/// <summary>
/// Sample MCP tools for demonstration purposes.
/// These tools can be invoked by MCP clients to perform various operations.
/// </summary>
internal class RandomTools
{
    private static readonly char[] _CHARS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
    
    [McpServerTool]
    [Description("Generates a random number between the specified minimum and maximum values.")]
    public int GetRandomNumber(
        [Description("Minimum value (inclusive)")] int min = 0,
        [Description("Maximum value (exclusive)")] int max = 100)
    {
        return Random.Shared.Next(min, max);
    }

    [McpServerTool]
    [Description("Generates a random datetime between the specified 'from' and 'to' values.")]
    public DateTime GetRandomDateTime(
        [Description()] DateTime from,
        [Description()] DateTime to
    )
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(to, from);
        var range = to - from;
        var delta = Random.Shared.NextInt64(0, range.Ticks);
        return from + TimeSpan.FromTicks(delta);
    }
    
    [McpServerTool]
    [Description("Generates a random boolean value.")]
    public bool GetRandomBoolean()
    {
        return Random.Shared.Next(0, 1) == 1;
    }
    
    [McpServerTool]
    [Description("Generates a random string of a specific length.")]
    public string GetRandomString(
        [Description("Length of the string to generate. Cannot be less than 1 or exceed 2048. If not specified, defaults to 16.")] int length = 16
    )
    {
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(length);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(length, 2048);
        var result = new char[length];
        for (var i = 0; i < length; i++)
        {
            var idx = Random.Shared.Next(0, _CHARS.Length);
            result[i] = _CHARS[idx];
        }
        return new string(result);
    }
    
    [McpServerTool]
    [Description("Generates a random version 4 GUID.")]
    public Guid GetRandomGuid() => Guid.NewGuid();
}
