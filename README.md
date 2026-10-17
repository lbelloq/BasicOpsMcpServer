# Basic Tools MCP Server

An [MCP](https://modelcontextprotocol.io/) (Model Context Protocol) server that exposes a set of basic utility tools to AI agents: random value generation, arithmetic operations on numbers, comparisons for numbers, datetimes, and timespans, plus JWT validation and inspection. It communicates over the `stdio` transport and is built as a self-contained .NET application, so no .NET runtime needs to be installed on the target machine.

## Features

| Tool                             | Description                                                                                                     |
|----------------------------------|-----------------------------------------------------------------------------------------------------------------|
| `get_random_number`              | Generates a random number between the specified minimum (inclusive) and maximum (exclusive). Defaults to 0–100. |
| `get_random_datetime`            | Generates a random datetime between the specified `from` and `to` values.                                       |
| `get_random_boolean`             | Generates a random boolean value (`true` or `false`).                                                           |
| `get_random_string`              | Generates a random alphanumeric string of the specified length (default 16, maximum 2048).                      |
| `add`                            | Adds two numbers.                                                                                               |
| `subtract`                       | Subtracts the second number from the first.                                                                     |
| `multiply`                       | Multiplies two numbers.                                                                                         |
| `divide`                         | Divides the first number by the second.                                                                         |
| `number_equal`                   | Compares two numbers and returns whether they are equal.                                                        |
| `number_less_than`               | Compares two numbers and returns whether the first is smaller than the second.                                  |
| `number_less_than_or_equal`      | Compares two numbers and returns whether the first is smaller than, or equal to, the second.                    |
| `number_greater_than`            | Compares two numbers and returns whether the first is greater than the second.                                  |
| `number_greater_than_or_equal`   | Compares two numbers and returns whether the first is greater than, or equal to, the second.                    |
| `datetime_equal`                 | Compares two datetimes and returns whether they are equal.                                                      |
| `datetime_less_than`             | Compares two datetimes and returns whether the first is smaller than the second.                                |
| `datetime_less_than_or_equal`    | Compares two datetimes and returns whether the first is smaller than, or equal to, the second.                  |
| `datetime_greater_than`          | Compares two datetimes and returns whether the first is greater than the second.                                |
| `datetime_greater_than_or_equal` | Compares two datetimes and returns whether the first is greater than, or equal to, the second.                  |
| `timespan_equal`                 | Compares two timespans and returns whether they are equal.                                                      |
| `timespan_less_than`             | Compares two timespans and returns whether the first is smaller than the second.                                |
| `timespan_less_than_or_equal`    | Compares two timespans and returns whether the first is smaller than, or equal to, the second.                  |
| `timespan_greater_than`          | Compares two timespans and returns whether the first is greater than the second.                                |
| `timespan_greater_than_or_equal` | Compares two timespans and returns whether the first is greater than, or equal to, the second.                  |
| `validate_jwt`                   | Validates a JWT using the specified Base64 signing key, with optional lifetime, audience and issuer checks.     |
| `list_jwt_claims`                | Lists the claims a JWT has, as key/value pairs.                                                                 |
| `get_jwt_expiration_date`        | Returns the JWT's expiration date, or null if the token has no exp claim.                                       |

## Why does this exist

One day I saw Opencode with Qwen3.8-27b take at least 5 minutes to determine if a JWT was expired or not.

As LLMs are (in a very basic way to describe it) text generators, they can struggle with simple tasks that require calculations. So this MCP server provides basic tools to the agent that can be used to perform those tasks in a simple, correct and efficient manner instead of relying on an LLM's output and wasting tokens for somehting that might come out wrong anyways.

## Local installation and usage

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (required to run the server from source with `dotnet run`)

### Configuration

To test this MCP server from source code without building a package, configure your IDE to run the project directly:

- **VS Code**: create a `<WORKSPACE DIRECTORY>/.vscode/mcp.json` file
- **Visual Studio**: create a `<SOLUTION DIRECTORY>\.mcp.json` file

```json
{
  "servers": {
    "BasicOps.McpServer": {
      "type": "stdio",
      "command": "dotnet",
      "args": [
        "run",
        "--project",
        "<PATH TO PROJECT DIRECTORY>"
      ]
    }
  }
}
```

Refer to the IDE documentation for more information on configuring and using MCP servers:

- [Use MCP servers in VS Code (Preview)](https://code.visualstudio.com/docs/copilot/chat/mcp-servers)
- [Use MCP servers in Visual Studio (Preview)](https://learn.microsoft.com/visualstudio/ide/mcp-servers)

### Testing the server

Once configured, ask Copilot Chat for a random number, for example `Give me 3 random numbers`. It should prompt you to use the `get_random_number` tool on the `BasicOps.McpServer` MCP server and show you the results.

## Technical details

| Component                                                                                   | Version          |
|---------------------------------------------------------------------------------------------|------------------|
| .NET (target framework)                                                                     | 10.0 (`net10.0`) |
| [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting) | 8.0.1            |
| [ModelContextProtocol](https://www.nuget.org/packages/ModelContextProtocol) (MCP C# SDK)    | 1.2.0            |

- **Transport**: `stdio` (protocol messages on stdout, logs on stderr)
- **Deployment**: self-contained single-file executable; no shared .NET runtime required on the target machine
- **Supported platforms** (runtime identifiers): `win-x64`, `win-arm64`, `osx-arm64`, `linux-x64`, `linux-arm64`, `linux-musl-x64`

For more information about MCP:

- [Official Documentation](https://modelcontextprotocol.io/)
- [Protocol Specification](https://spec.modelcontextprotocol.io/)
- [MCP C# SDK](https://modelcontextprotocol.github.io/csharp-sdk)

## Contributions and behavior

No pull requests are currently accepted, though that might change in the future. 

If you want to suggest a feature or report a bug, you're welcome to open an issue on the [GitHub repository](https://github.com/modelcontextprotocol/basic-ops-mcp-server). 

- Please be respectful and concise in your communication.
- Only technical issues/requests will be allowed. Any other kind of communication will be ignored.