using System;

/// <summary>
/// Represents the weather condition for a given city.
/// </summary>
[Serializable]
public class WeatherItem
{
    /// <summary>
    /// The name of the weather condition (e.g., "Clear")
    /// </summary>
    public string main;

    /// <summary>
    /// The description of the weather condition (e.g., "clear sky")
    /// </summary>
    public string description;
}