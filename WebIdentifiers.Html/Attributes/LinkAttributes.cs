﻿namespace WebIdentifiers.Html.Attributes;

/// /// <summary>
/// Provides access to the attributes of the link element.
/// </summary>
public class LinkAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>crossorigin</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CrossOrigin(string? value) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>href</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Href(string? value) => HtmlAttributes.Href(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>hreflang</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute HrefLang(string? value) => HtmlAttributes.HrefLang(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>media</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Media(string? value) => HtmlAttributes.Media(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute ReferrerPolicy(string? value) => HtmlAttributes.ReferrerPolicy(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>rel</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Rel(string? value) => HtmlAttributes.Rel(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>sizes</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Sizes(string? value) => HtmlAttributes.Sizes(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>type</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Type(string? value) => HtmlAttributes.Type(value);
}