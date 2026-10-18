# Basic Tools MCP Server

An [MCP](https://modelcontextprotocol.io/) (Model Context Protocol) server that exposes a set of basic utility tools to AI agents: random value generation, arithmetic operations on numbers, comparisons for numbers, datetimes, and timespans, string manipulation, unit conversions, plus JWT validation and inspection. It communicates over the `stdio` transport and is built as a self-contained .NET application, so no .NET runtime needs to be installed on the target machine.

## Features

| Tool                             | Description                                                                                                     |
|----------------------------------|-----------------------------------------------------------------------------------------------------------------|
| `get_random_number`              | Generates a random number between the specified minimum (inclusive) and maximum (exclusive). Defaults to 0–100. |
| `get_random_datetime`            | Generates a random datetime between the specified `from` and `to` values.                                       |
| `get_random_boolean`             | Generates a random boolean value (`true` or `false`).                                                           |
| `get_random_string`              | Generates a random alphanumeric string of the specified length (default 16, maximum 2048).                      |
| `get_random_guid`                | Generates a random version 4 GUID.                                                                              |
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
| `get_string_length`              | Returns the provided string's length, measured in visible characters rather than bytes.                         |
| `string_to_uppercase`            | Returns the provided string converted to uppercase.                                                             |
| `string_to_lowercase`            | Returns the provided string converted to lowercase.                                                             |
| `validate_jwt`                   | Validates a JWT using the specified Base64 signing key, with optional lifetime, audience and issuer checks.     |
| `list_jwt_claims`                | Lists the claims a JWT has, as key/value pairs.                                                                 |
| `get_jwt_expiration_date`        | Returns the JWT's expiration date, or null if the token has no exp claim.                                       |
| `meters_to_kilometers`           | Converts meters to kilometers.                                                                                  |
| `kilometers_to_meters`           | Converts kilometers to meters.                                                                                  |
| `meters_to_miles`                | Converts meters to miles.                                                                                       |
| `miles_to_meters`                | Converts miles to meters.                                                                                       |
| `kilometers_to_miles`            | Converts kilometers to miles.                                                                                   |
| `miles_to_kilometers`            | Converts miles to kilometers.                                                                                   |
| `celsius_to_fahrenheit`          | Converts degrees Celsius to degrees Fahrenheit.                                                                 |
| `fahrenheit_to_celsius`          | Converts degrees Fahrenheit to degrees Celsius.                                                                 |
| `celsius_to_kelvin`              | Converts degrees Celsius to kelvins.                                                                            |
| `kelvin_to_celsius`              | Converts kelvins to degrees Celsius.                                                                            |
| `fahrenheit_to_kelvin`           | Converts degrees Fahrenheit to kelvins.                                                                         |
| `kelvin_to_fahrenheit`           | Converts kelvins to degrees Fahrenheit.                                                                         |
| `kg_to_grams`                    | Converts kilograms to grams.                                                                                    |
| `grams_to_kg`                    | Converts grams to kilograms.                                                                                    |
| `kg_to_pounds`                   | Converts kilograms to pounds.                                                                                   |
| `pounds_to_kg`                   | Converts pounds to kilograms.                                                                                   |
| `kg_to_stone`                    | Converts kilograms to stone.                                                                                    |
| `stone_to_kg`                    | Converts stone to kilograms.                                                                                    |
| `kmph_to_mph`                    | Converts kilometers per hour to miles per hour.                                                                 |
| `mph_to_kmph`                    | Converts miles per hour to kilometers per hour.                                                                 |
| `ms_to_kmph`                     | Converts meters per second to kilometers per hour.                                                              |
| `kmph_to_ms`                     | Converts kilometers per hour to meters per second.                                                              |
| `sq_meters_to_sq_km`             | Converts square meters to square kilometers.                                                                    |
| `sq_km_to_sq_meters`             | Converts square kilometers to square meters.                                                                    |
| `sq_meters_to_sq_miles`          | Converts square meters to square miles.                                                                         |
| `sq_miles_to_sq_meters`          | Converts square miles to square meters.                                                                         |
| `liters_to_milliliters`          | Converts liters to milliliters.                                                                                 |
| `milliliters_to_liters`          | Converts milliliters to liters.                                                                                 |
| `liters_to_gallons`              | Converts liters to gallons.                                                                                     |
| `gallons_to_liters`              | Converts gallons to liters.                                                                                     |
| `pascal_to_bar`                  | Converts pascals to bar.                                                                                        |
| `bar_to_pascal`                  | Converts bar to pascals.                                                                                        |
| `pascal_to_psi`                  | Converts pascals to pounds per square inch (psi).                                                               |
| `psi_to_pascal`                  | Converts pounds per square inch (psi) to pascals.                                                               |
| `joules_to_calories`             | Converts joules to calories.                                                                                    |
| `calories_to_joules`             | Converts calories to joules.                                                                                    |
| `joules_to_k_wh`                 | Converts joules to kilowatt-hours.                                                                              |
| `k_wh_to_joules`                 | Converts kilowatt-hours to joules.                                                                              |
| `bytes_to_kilobytes`             | Converts bytes to kilobytes.                                                                                    |
| `kilobytes_to_bytes`             | Converts kilobytes to bytes.                                                                                    |
| `bytes_to_megabytes`             | Converts bytes to megabytes.                                                                                    |
| `megabytes_to_bytes`             | Converts megabytes to bytes.                                                                                    |
| `megabytes_to_gigabytes`         | Converts megabytes to gigabytes.                                                                                |
| `gigabytes_to_megabytes`         | Converts gigabytes to megabytes.                                                                                |
| `unix_timestamp_to_date_time`    | Converts a UNIX timestamp to DateTime.                                                                          |
| `date_time_to_unix_timestamp`    | Converts a DateTime to UNIX timestamp.                                                                          |

## Why does this exist

One day I saw Opencode with Qwen3.8-27b take at least 5 minutes to determine if a JWT was expired or not.

As LLMs are (in a very basic way to describe it) text generators, they can struggle with simple tasks that require calculations. So this MCP server provides basic tools to the agent that can be used to perform those tasks in a simple, correct and efficient manner instead of relying on an LLM's output and wasting tokens for somehting that might come out wrong anyways.

## Local installation and usage

TODO

## Development

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (required to run the server from source with `dotnet run`)

### Configuration

No configuration needed for development.

### Testing the server

- Publish the app.
- Copy the resulting binary to a directory of your preference.
- Create in the same directoy the file needed for your agent to reocgnize the MCP server.
    - Opencode example:

```json
{
  "$schema": "https://opencode.ai/config.json",
  "mcp": {
    "basic-ops": {
      "type": "local",
      "command": [ "./BasicOps.McpServer" ],
      "enabled": true
    }
  },
  "tools": {
    "basic-ops": true
  }
```

- Run your agent and check the MCP is active.
- Invoke the MCP's tools.

## Technical details

| Component                                                                                                     | Version |
|---------------------------------------------------------------------------------------------------------------|---------|
| .NET (target framework)                                                                                       | 10.0    |
| [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting)                   | 8.0.1   |
| [ModelContextProtocol](https://www.nuget.org/packages/ModelContextProtocol) (MCP C# SDK)                      | 1.2.0   |
| [Microsoft.IdentityModel.JsonWebTokens](https://www.nuget.org/packages/Microsoft.IdentityModel.JsonWebTokens) | 1.2.0   |

- **Transport**: `stdio` (protocol messages on stdout, logs on stderr)
- **Deployment**: self-contained single-file executable; no shared .NET runtime required on the target machine
- **Supported platforms** (runtime identifiers): `win-x64`, `win-arm64`, `osx-arm64`, `linux-x64`, `linux-arm64`, `linux-musl-x64`

For more information about MCP:

- [Official Documentation](https://modelcontextprotocol.io/)
- [Protocol Specification](https://spec.modelcontextprotocol.io/)
- [MCP C# SDK](https://modelcontextprotocol.github.io/csharp-sdk)

## Contributions and behavior

No pull requests are currently accepted, though that might change in the future. 

If you want to suggest a feature or report a bug, you're welcome to open an issue on the [Issues section](https://github.com/lbelloq/BasicOpsMcpServer/issues). 

- Please be respectful and concise in your communication.
- Only technical issues/requests will be allowed. Any other kind of communication will be ignored.