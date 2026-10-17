using System.ComponentModel;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

internal class StringTools
{
    [McpServerTool]
    [Description("Returns the provided string's length. It measures visible characters, not bytes.")]
    public int GetStringLength(
        [Description("String whose length to calculate.")] string s
    )
    {
        return string.IsNullOrEmpty(s) ? 0 : s.EnumerateRunes().Count();
    }
    
    [McpServerTool]
    [Description("Returns the provided string in uppercase.")]
    public string StringToUppercase(
        [Description("String to convert to uppercase.")] string s
    )
    {
        return string.IsNullOrEmpty(s) ? "" : s.ToUpperInvariant();
    }
    
    [McpServerTool]
    [Description("Returns the provided string in lowercase.")]
    public string StringToLowercase(
        [Description("String to convert to lowercase.")] string s
    )
    {
        return string.IsNullOrEmpty(s) ? "" : s.ToLowerInvariant();
    }
}