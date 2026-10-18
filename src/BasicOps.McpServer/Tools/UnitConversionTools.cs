using System.ComponentModel;
using ModelContextProtocol.Server;

namespace BasicOps.McpServer.Tools;

internal class UnitConversionTools
{
    private const decimal _M_TO_KM = 1000;
    private const decimal _M_TO_MILES = 1609.344M;
    private const decimal _KM_TO_MILES = 1.609344M;
    private const decimal _C_TO_F = 9M / 5M;
    private const decimal _F_TO_C = 5M / 9M;
    private const decimal _C_TO_K = 273.15M;
    private const decimal _KG_TO_G = 1000;
    private const decimal _KG_TO_LB = 2.2046226218M;
    private const decimal _KG_TO_ST = 0.157473044M;
    private const decimal _KMH_TO_MH = 0.157473044M;
    private const decimal _MS_TO_KMH = 3.6M;
    private const decimal _SQ_M_TO_SQ_KM = 1_000_000.0M;
    private const decimal _SQ_M_TO_SQ_MILES = 2_589_988.11M;
    private const decimal _L_TO_ML = 1000M;
    private const decimal _L_TO_GAL = 0.2641720524M;
    private const decimal _PA_TO_BAR = 100_000M;
    private const decimal _PA_TO_PSI = 6894.75729M;
    private const decimal _J_TO_CAL = 4.184M;
    private const decimal _J_TO_KWH = 3_600_000M;
    private const decimal _B_TO_KB = 1024M;
    private const decimal _B_TO_MB = 1024M * 1024M;
    private const decimal _MB_TO_GB = 1024M;

    [McpServerTool]
    [Description("Converts meters to kilometers.")]
    public decimal MetersToKilometers(
        [Description("Distance in meters")] decimal m)
    {
        return m / _M_TO_KM;
    }

    [McpServerTool]
    [Description("Converts kilometers to meters.")]
    public decimal KilometersToMeters(
        [Description("Distance in kilometers")] decimal km)
    {
        return km * _M_TO_KM;
    }

    [McpServerTool]
    [Description("Converts meters to miles.")]
    public decimal MetersToMiles(
        [Description("Distance in meters")] decimal m)
    {
        return m / _M_TO_MILES;
    }

    [McpServerTool]
    [Description("Converts miles to meters.")]
    public decimal MilesToMeters(
        [Description("Distance in miles")] decimal mi)
    {
        return mi * _M_TO_MILES;
    }

    [McpServerTool]
    [Description("Converts kilometers to miles.")]
    public decimal KilometersToMiles(
        [Description("Distance in kilometers")] decimal km)
    {
        return km / _KM_TO_MILES;
    }

    [McpServerTool]
    [Description("Converts miles to kilometers.")]
    public decimal MilesToKilometers(
        [Description("Distance in miles")] decimal mi)
    {
        return mi * _KM_TO_MILES;
    }

    [McpServerTool]
    [Description("Converts degrees Celsius to degrees Fahrenheit.")]
    public decimal CelsiusToFahrenheit(
        [Description("Temperature in degrees Celsius")] decimal c)
    {
        return c * _C_TO_F + 32;
    }

    [McpServerTool]
    [Description("Converts degrees Fahrenheit to degrees Celsius.")]
    public decimal FahrenheitToCelsius(
        [Description("Temperature in degrees Fahrenheit")] decimal f)
    {
        return (f - 32) * _F_TO_C;
    }

    [McpServerTool]
    [Description("Converts degrees Celsius to kelvins.")]
    public decimal CelsiusToKelvin(
        [Description("Temperature in degrees Celsius")] decimal c)
    {
        return c + _C_TO_K;
    }

    [McpServerTool]
    [Description("Converts kelvins to degrees Celsius.")]
    public decimal KelvinToCelsius(
        [Description("Temperature in kelvins")] decimal k)
    {
        return k - _C_TO_K;
    }

    [McpServerTool]
    [Description("Converts degrees Fahrenheit to kelvins.")]
    public decimal FahrenheitToKelvin(
        [Description("Temperature in degrees Fahrenheit")] decimal f)
    {
        return (f - 32) * _F_TO_C + _C_TO_K;
    }

    [McpServerTool]
    [Description("Converts kelvins to degrees Fahrenheit.")]
    public decimal KelvinToFahrenheit(
        [Description("Temperature in kelvins")] decimal k)
    {
        return (k - _C_TO_K) * _C_TO_F + 32;
    }

    [McpServerTool]
    [Description("Converts kilograms to grams.")]
    public decimal KgToGrams(
        [Description("Mass in kilograms")] decimal kg)
    {
        return kg * _KG_TO_G;
    }

    [McpServerTool]
    [Description("Converts grams to kilograms.")]
    public decimal GramsToKg(
        [Description("Mass in grams")] decimal g)
    {
        return g / _KG_TO_G;
    }

    [McpServerTool]
    [Description("Converts kilograms to pounds.")]
    public decimal KgToPounds(
        [Description("Mass in kilograms")] decimal kg)
    {
        return kg * _KG_TO_LB;
    }

    [McpServerTool]
    [Description("Converts pounds to kilograms.")]
    public decimal PoundsToKg(
        [Description("Mass in pounds")] decimal lb)
    {
        return lb / _KG_TO_LB;
    }

    [McpServerTool]
    [Description("Converts kilograms to stone.")]
    public decimal KgToStone(
        [Description("Mass in kilograms")] decimal kg)
    {
        return kg * _KG_TO_ST;
    }

    [McpServerTool]
    [Description("Converts stone to kilograms.")]
    public decimal StoneToKg(
        [Description("Mass in stone")] decimal st)
    {
        return st / _KG_TO_ST;
    }

    [McpServerTool]
    [Description("Converts kilometers per hour to miles per hour.")]
    public decimal KmphToMph(
        [Description("Speed in kilometers per hour")] decimal kmh)
    {
        return kmh / _KMH_TO_MH;
    }

    [McpServerTool]
    [Description("Converts miles per hour to kilometers per hour.")]
    public decimal MphToKmph(
        [Description("Speed in miles per hour")] decimal mph)
    {
        return mph * _KMH_TO_MH;
    }

    [McpServerTool]
    [Description("Converts meters per second to kilometers per hour.")]
    public decimal MsToKmph(
        [Description("Speed in meters per second")] decimal ms)
    {
        return ms * _MS_TO_KMH;
    }

    [McpServerTool]
    [Description("Converts kilometers per hour to meters per second.")]
    public decimal KmphToMs(
        [Description("Speed in kilometers per hour")] decimal kmh)
    {
        return kmh / _MS_TO_KMH;
    }

    [McpServerTool]
    [Description("Converts square meters to square kilometers.")]
    public decimal SqMetersToSqKm(
        [Description("Area in square meters")] decimal m2)
    {
        return m2 / _SQ_M_TO_SQ_KM;
    }

    [McpServerTool]
    [Description("Converts square kilometers to square meters.")]
    public decimal SqKmToSqMeters(
        [Description("Area in square kilometers")] decimal km2)
    {
        return km2 * _SQ_M_TO_SQ_KM;
    }

    [McpServerTool]
    [Description("Converts square meters to square miles.")]
    public decimal SqMetersToSqMiles(
        [Description("Area in square meters")] decimal m2)
    {
        return m2 / _SQ_M_TO_SQ_MILES;
    }

    [McpServerTool]
    [Description("Converts square miles to square meters.")]
    public decimal SqMilesToSqMeters(
        [Description("Area in square miles")] decimal mi2)
    {
        return mi2 * _SQ_M_TO_SQ_MILES;
    }

    [McpServerTool]
    [Description("Converts liters to milliliters.")]
    public decimal LitersToMilliliters(
        [Description("Volume in liters")] decimal l)
    {
        return l * _L_TO_ML;
    }

    [McpServerTool]
    [Description("Converts milliliters to liters.")]
    public decimal MillilitersToLiters(
        [Description("Volume in milliliters")] decimal ml)
    {
        return ml / _L_TO_ML;
    }

    [McpServerTool]
    [Description("Converts liters to gallons.")]
    public decimal LitersToGallons(
        [Description("Volume in liters")] decimal l)
    {
        return l * _L_TO_GAL;
    }

    [McpServerTool]
    [Description("Converts gallons to liters.")]
    public decimal GallonsToLiters(
        [Description("Volume in gallons")] decimal gal)
    {
        return gal / _L_TO_GAL;
    }

    [McpServerTool]
    [Description("Converts pascals to bar.")]
    public decimal PascalToBar(
        [Description("Pressure in pascals")] decimal pa)
    {
        return pa / _PA_TO_BAR;
    }

    [McpServerTool]
    [Description("Converts bar to pascals.")]
    public decimal BarToPascal(
        [Description("Pressure in bar")] decimal bar)
    {
        return bar * _PA_TO_BAR;
    }

    [McpServerTool]
    [Description("Converts pascals to pounds per square inch (psi).")]
    public decimal PascalToPSI(
        [Description("Pressure in pascals")] decimal pa)
    {
        return pa / _PA_TO_PSI;
    }

    [McpServerTool]
    [Description("Converts pounds per square inch (psi) to pascals.")]
    public decimal PSIToPascal(
        [Description("Pressure in pounds per square inch (psi)")] decimal psi)
    {
        return psi * _PA_TO_PSI;
    }

    [McpServerTool]
    [Description("Converts joules to calories.")]
    public decimal JoulesToCalories(
        [Description("Energy in joules")] decimal j)
    {
        return j / _J_TO_CAL;
    }

    [McpServerTool]
    [Description("Converts calories to joules.")]
    public decimal CaloriesToJoules(
        [Description("Energy in calories")] decimal cal)
    {
        return cal * _J_TO_CAL;
    }

    [McpServerTool]
    [Description("Converts joules to kilowatt-hours.")]
    public decimal JoulesToKWh(
        [Description("Energy in joules")] decimal j)
    {
        return j / _J_TO_KWH;
    }

    [McpServerTool]
    [Description("Converts kilowatt-hours to joules.")]
    public decimal KWhToJoules(
        [Description("Energy in kilowatt-hours")] decimal kwh)
    {
        return kwh * _J_TO_KWH;
    }

    [McpServerTool]
    [Description("Converts bytes to kilobytes.")]
    public decimal BytesToKilobytes(
        [Description("Data size in bytes")] decimal b)
    {
        return b / _B_TO_KB;
    }

    [McpServerTool]
    [Description("Converts kilobytes to bytes.")]
    public decimal KilobytesToBytes(
        [Description("Data size in kilobytes")] decimal kb)
    {
        return kb * _B_TO_KB;
    }

    [McpServerTool]
    [Description("Converts bytes to megabytes.")]
    public decimal BytesToMegabytes(
        [Description("Data size in bytes")] decimal b)
    {
        return b / _B_TO_MB;
    }

    [McpServerTool]
    [Description("Converts megabytes to bytes.")]
    public decimal MegabytesToBytes(
        [Description("Data size in megabytes")] decimal mb)
    {
        return mb * _B_TO_MB;
    }

    [McpServerTool]
    [Description("Converts megabytes to gigabytes.")]
    public decimal MegabytesToGigabytes(
        [Description("Data size in megabytes")] decimal mb)
    {
        return mb / _MB_TO_GB;
    }

    [McpServerTool]
    [Description("Converts gigabytes to megabytes.")]
    public decimal GigabytesToMegabytes(
        [Description("Data size in gigabytes")] decimal gb)
    {
        return gb * _MB_TO_GB;
    }
    
    [McpServerTool]
    [Description("Converts a UNIX timestamp to DateTime.")]
    public DateTime UnixTimestampToDateTime(
        [Description("UNIX timestamp in seconds since 1970-01-01T00:00:00Z")] long ts)
    {
        return DateTimeOffset.FromUnixTimeSeconds(ts).UtcDateTime;
    }
    
    [McpServerTool]
    [Description("Converts a DateTime to UNIX timestamp.")]
    public long DateTimeToUnixTimestamp(
        [Description("DateTime to convert (treated as local time if no offset is specified)")] DateTime date)
    {
        return new DateTimeOffset(date).ToUnixTimeSeconds();
    }
}
