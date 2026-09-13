double celsius = 23.5;

const double F_factor = 9.0 / 5.0;
const double F_offset = 32.0;
const double K_offest = 273.15;

double fahrenheit = celsius * F_factor + F_offset;
double kelvin = celsius + K_offest;

Console.WriteLine($"{celsius}°C = {fahrenheit:F2}°F = {kelvin:F2}K");
