﻿namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the meter element.
/// </summary>
public class MeterAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>form</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>high</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute High(string? value) => HtmlAttributes.High(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>low</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Low(string? value) => HtmlAttributes.Low(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>max</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Max(string? value) => HtmlAttributes.Max(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>min</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Min(string? value) => HtmlAttributes.Min(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>optimum</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Optimum(string? value) => HtmlAttributes.Optimum(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>value</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Value(string? value) => HtmlAttributes.Value(value);
}