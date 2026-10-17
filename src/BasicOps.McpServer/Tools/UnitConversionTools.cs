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
    
    public decimal MetersToKilometers(decimal m) => m / _M_TO_KM;
    public decimal KilometersToMeters(decimal km) => km * _M_TO_KM;

    public decimal MetersToMiles(decimal m) => m / _M_TO_MILES;
    public decimal MilesToMeters(decimal mi) => mi * _M_TO_MILES;

    public decimal KilometersToMiles(decimal km) => km / _KM_TO_MILES;
    public decimal MilesToKilometers(decimal mi) => mi * _KM_TO_MILES;

    // -------- TEMPERATURE --------

    public decimal CelsiusToFahrenheit(decimal c) => c * _C_TO_F + 32;
    public decimal FahrenheitToCelsius(decimal f) => (f - 32) * _F_TO_C;

    public decimal CelsiusToKelvin(decimal c) => c + _C_TO_K;
    public decimal KelvinToCelsius(decimal k) => k - _C_TO_K;

    public decimal FahrenheitToKelvin(decimal f) => (f - 32) * _F_TO_C + _C_TO_K;

    public decimal KelvinToFahrenheit(decimal k) => (k - _C_TO_K) * _C_TO_F + 32;

    // -------- WEIGHT / MASS --------

    public decimal KgToGrams(decimal kg) => kg * _KG_TO_G;
    public decimal GramsToKg(decimal g) => g / _KG_TO_G;

    public decimal KgToPounds(decimal kg) => kg * _KG_TO_LB;
    public decimal PoundsToKg(decimal lb) => lb / _KG_TO_LB;

    public decimal KgToStone(decimal kg) => kg * _KG_TO_ST;
    public decimal StoneToKg(decimal st) => st / _KG_TO_ST;

    // -------- SPEED --------

    public decimal KmphToMph(decimal kmh) => kmh / _KMH_TO_MH;
    public decimal MphToKmph(decimal mph) => mph * _KMH_TO_MH;

    public decimal MsToKmph(decimal ms) => ms * 3.6M;
    public decimal KmphToMs(decimal kmh) => kmh / 3.6M;

    // -------- AREA --------

    public decimal SqMetersToSqKm(decimal m2) => m2 / 1_000_000.0M;
    public decimal SqKmToSqMeters(decimal km2) => km2 * 1_000_000.0M;

    public decimal SqMetersToSqMiles(decimal m2) => m2 / 2_589_988.11M;
    public decimal SqMilesToSqMeters(decimal mi2) => mi2 * 2_589_988.11M;

    // -------- VOLUME --------

    public decimal LitersToMilliliters(decimal l) => l * 1000M;
    public decimal MillilitersToLiters(decimal ml) => ml / 1000M;

    public decimal LitersToGallons(decimal l) => l * 0.2641720524M;
    public decimal GallonsToLiters(decimal gal) => gal / 0.2641720524M;

    // -------- PRESSURE --------

    public decimal PascalToBar(decimal pa) => pa / 100_000M;
    public decimal BarToPascal(decimal bar) => bar * 100_000M;

    public decimal PascalToPSI(decimal pa) => pa / 6894.75729M;
    public decimal PSIToPascal(decimal psi) => psi * 6894.75729M;

    // -------- ENERGY --------

    public decimal JoulesToCalories(decimal j) => j / 4.184M;
    public decimal CaloriesToJoules(decimal cal) => cal * 4.184M;

    public decimal JoulesToKWh(decimal j) => j / 3_600_000M;
    public decimal KWhToJoules(decimal kwh) => kwh * 3_600_000M;

    // -------- DATA SIZES --------

    public decimal BytesToKilobytes(decimal b) => b / 1024M;
    public decimal KilobytesToBytes(decimal kb) => kb * 1024M;

    public decimal BytesToMegabytes(decimal b) => b / (1024M * 1024M);
    public decimal MegabytesToBytes(decimal mb) => mb * 1024M * 1024M;

    public decimal MegabytesToGigabytes(decimal mb) => mb / 1024M;
    public decimal GigabytesToMegabytes(decimal gb) => gb * 1024M;
}