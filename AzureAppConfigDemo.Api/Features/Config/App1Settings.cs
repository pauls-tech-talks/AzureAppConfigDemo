﻿namespace AzureAppConfigDemo.Api.Features.Config;

/// <summary>
/// Settings for this app.
/// </summary>
public class App1Settings
{
    /// <summary>
    /// Gets or sets the palette settings.
    /// </summary>
    public PaletteSettings? Palette { get; set; }
}

/// <summary>
/// Palette settings.
/// </summary>
public class PaletteSettings
{
    /// <summary>
    /// Gets or sets the background colour.
    /// </summary>
    public string? Background { get; set; }

    /// <summary>
    /// Gets or sets the foreground colour.
    /// </summary>
    public string? Foreground { get; set; }
}
