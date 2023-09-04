﻿namespace WebIdentifiers.Html.Attributes;

/// <summary>
/// Provides access to the attributes of the img element.
/// </summary>
public class ImgAttributes : GlobalAttributes
{
    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>alt</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Alt(string? value) => HtmlAttributes.Alt(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>crossOrigin</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute CrossOrigin(string? value) => HtmlAttributes.CrossOrigin(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>decoding</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Decoding(string? value) => HtmlAttributes.Decoding(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>height</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Height(string? value) => HtmlAttributes.Height(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>ismap</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute IsMap(string? value) => HtmlAttributes.IsMap(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>loading</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Loading(string? value) => HtmlAttributes.Loading(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>referrerpolicy</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute ReferrerPolicy(string? value) => HtmlAttributes.ReferrerPolicy(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>sizes</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Sizes(string? value) => HtmlAttributes.Sizes(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>src</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Src(string? value) => HtmlAttributes.Src(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>srcset</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute SrcSet(string? value) => HtmlAttributes.SrcSet(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>usemap</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute UseMap(string? value) => HtmlAttributes.UseMap(value);

    /// <summary>
    /// Creates a new <see cref="HtmlAttribute"/> initialized with the <c>width</c> attribute name and optionally specified value.
    /// </summary>
    /// <param name="value">An optional value to apply to the attribute.</param>
    /// <returns>The new <see cref="HtmlAttribute"/> instance.</returns>
    public HtmlAttribute Width(string? value) => HtmlAttributes.Width(value);
}