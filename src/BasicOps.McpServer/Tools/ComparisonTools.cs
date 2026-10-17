using System.ComponentModel;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

internal class ComparisonTools
{
    [McpServerTool]
    [Description("Compares two numbers and returns if both are equal.")]
    public bool NumberEqual(
        [Description("First value")] decimal d1,
        [Description("Second value")] decimal d2)
    {
        return d1 == d2;
    }
    
    [McpServerTool]
    [Description("Compares two numbers and returns if the first is smaller than the second.")]
    public bool NumberLessThan(
        [Description("First value")] decimal d1,
        [Description("Second value")] decimal d2)
    {
        return d1 < d2;
    }
    
    [McpServerTool]
    [Description("Compares two numbers and returns if the first is smaller than, or equal to, the second.")]
    public bool NumberLessThanOrEqual(
        [Description("First value")] decimal d1,
        [Description("Second value")] decimal d2)
    {
        return d1 <= d2;
    }
    
    [McpServerTool]
    [Description("Compares two numbers and returns if the first is greater than the second.")]
    public bool NumberGreaterThan(
        [Description("First value")] decimal d1,
        [Description("Second value")] decimal d2)
    {
        return d1 > d2;
    }
    
    [McpServerTool]
    [Description("Compares two numbers and returns if the first is greater than, or equal to, the second.")]
    public bool NumberGreaterThanOrEqual(
        [Description("First value")] decimal d1,
        [Description("Second value")] decimal d2)
    {
        return d1 >= d2;
    }
    
    [McpServerTool]
    [Description("Compares two datetimes and returns if both are equal.")]
    public bool DateTimeEqual(
        [Description("First value")] DateTime d1,
        [Description("Second value")] DateTime d2)
    {
        return d1 == d2;
    }
    
    [McpServerTool]
    [Description("Compares two datetimes and returns if the first is smaller than the second.")]
    public bool DateTimeLessThan(
        [Description("First value")] DateTime d1,
        [Description("Second value")] DateTime d2)
    {
        return d1 < d2;
    }
    
    [McpServerTool]
    [Description("Compares two datetimes and returns if the first is smaller than, or equal to, the second.")]
    public bool DateTimeLessThanOrEqual(
        [Description("First value")] DateTime d1,
        [Description("Second value")] DateTime d2)
    {
        return d1 <= d2;
    }
    
    [McpServerTool]
    [Description("Compares two datetimes and returns if the first is greater than the second.")]
    public bool DateTimeGreaterThan(
        [Description("First value")] DateTime d1,
        [Description("Second value")] DateTime d2)
    {
        return d1 > d2;
    }
    
    [McpServerTool]
    [Description("Compares two datetimes and returns if the first is greater than, or equal to, the second.")]
    public bool DateTimeGreaterThanOrEqual(
        [Description("First value")] DateTime d1,
        [Description("Second value")] DateTime d2)
    {
        return d1 >= d2;
    }
    
    [McpServerTool]
    [Description("Compares two timespans and returns if both are equal.")]
    public bool TimeSpanEqual(
        [Description("First value")] TimeSpan d1,
        [Description("Second value")] TimeSpan d2)
    {
        return d1 == d2;
    }
    
    [McpServerTool]
    [Description("Compares two timespans and returns if the first is smaller than the second.")]
    public bool TimeSpanLessThan(
        [Description("First value")] TimeSpan d1,
        [Description("Second value")] TimeSpan d2)
    {
        return d1 < d2;
    }
    
    [McpServerTool]
    [Description("Compares two timespans and returns if the first is smaller than, or equal to, the second.")]
    public bool TimeSpanLessThanOrEqual(
        [Description("First value")] TimeSpan d1,
        [Description("Second value")] TimeSpan d2)
    {
        return d1 <= d2;
    }
    
    [McpServerTool]
    [Description("Compares two timespans and returns if the first is greater than the second.")]
    public bool TimeSpanGreaterThan(
        [Description("First value")] TimeSpan d1,
        [Description("Second value")] TimeSpan d2)
    {
        return d1 > d2;
    }
    
    [McpServerTool]
    [Description("Compares two timespans and returns if the first is greater than, or equal to, the second.")]
    public bool TimeSpanGreaterThanOrEqual(
        [Description("First value")] TimeSpan d1,
        [Description("Second value")] TimeSpan d2)
    {
        return d1 >= d2;
    }
}