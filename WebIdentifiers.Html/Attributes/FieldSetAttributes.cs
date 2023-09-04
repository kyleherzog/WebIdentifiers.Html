﻿namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the fieldset element.
/// </summary>
public class FieldSetAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>disabled</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Disabled(string? value) => HtmlAttributes.Disabled(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>form</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Form(string? value) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the attribute name <c>name</c> and an optional specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Name(string? value) => HtmlAttributes.Name(value);
}