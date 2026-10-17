using System.ComponentModel;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

internal class ArithmeticTools
{
    [McpServerTool]
    [Description("Adds two numbers.")]
    public decimal Add(
        [Description("First value")] decimal firstSumand,
        [Description("Second value")] decimal secondSumand)
    {
        return decimal.Add(firstSumand, secondSumand);
    }
    
    [McpServerTool]
    [Description("Subtracts two numbers.")]
    public decimal Subtract(
        [Description("First value")] decimal minuend,
        [Description("Second value")] decimal subtrahend)
    {
        return decimal.Subtract(minuend, subtrahend);
    }
    
    [McpServerTool]
    [Description("Multiplies two numbers.")]
    public decimal Multiply(
        [Description("First value")] decimal multiplicand,
        [Description("Second value")] decimal multiplier)
    {
        return decimal.Multiply(multiplicand, multiplier);
    }
    
    [McpServerTool]
    [Description("Divides two numbers.")]
    public decimal Divide(
        [Description("First value")] decimal dividend,
        [Description("Second value")] decimal divisor)
    {
        return decimal.Divide(dividend, divisor);
    }
}