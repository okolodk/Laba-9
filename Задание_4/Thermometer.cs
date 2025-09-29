using System;

public delegate void TemperatureCount(string mas);
public class Thermometer
{
    public event TemperatureCount TemperatureTooHigh;

    public void Measure(int value)
    {
        Console.WriteLine($"Tемпература = {value}");

        if (value > 100)
        {
            TemperatureTooHigh?.Invoke($"Tемпература превышена: {value}");
        }
    }
}
