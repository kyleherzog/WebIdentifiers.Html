﻿namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the object element.
/// </summary>
public class ObjectAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>data</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Data(string? value = null) => HtmlAttributes.Data(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>form</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Form(string? value = null) => HtmlAttributes.Form(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>height</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Height(string? value = null) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>name</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Name(string? value = null) => HtmlAttributes.Name(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Type(string? value = null) => HtmlAttributes.Type(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>typemustmatch</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute TypeMustMatch(string? value = null) => HtmlAttributes.TypeMustMatch(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>usemap</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute UseMap(string? value = null) => HtmlAttributes.UseMap(value);

    /// <summary>
    /// Creates a new <see cref="MarkupAttribute"/> initialized with the <c>width</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="MarkupAttribute"/> instance.</returns>
    public MarkupAttribute Width(string? value = null) => HtmlAttributes.Width(value);
}