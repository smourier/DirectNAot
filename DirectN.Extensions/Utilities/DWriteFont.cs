namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows10.0.10240")]
public class DWriteFont(IComObject<IDWriteFontFaceReference> reference) : InterlockedComObject<IDWriteFontFaceReference>(reference), IEquatable<DWriteFont>
{
    public IDictionary<DWRITE_FONT_PROPERTY_ID, IReadOnlyList<DWriteLocalizedString>> Properties { get; } = new Dictionary<DWRITE_FONT_PROPERTY_ID, IReadOnlyList<DWriteLocalizedString>>();
    public uint FontFaceIndex => NativeObject.GetFontFaceIndex();
    public DWRITE_FONT_SIMULATIONS Simulations => NativeObject.GetSimulations();
    public ulong LocalFileSize => NativeObject.GetLocalFileSize();
    public DWRITE_LOCALITY Locality => NativeObject.GetLocality();
    public string FullName { get; internal set; } = string.Empty;
    public string? FamilyName => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FAMILY_NAME, out var names) && names.Count > 0 ? names[0].String : null;
    public string? Win32FamilyName => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WIN32_FAMILY_NAME, out var names) && names.Count > 0 ? names[0].String : null;
    public string? FaceName => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_FACE_NAME, out var names) && names.Count > 0 ? names[0].String : null;
    public string? TypographicFaceName => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_TYPOGRAPHIC_FACE_NAME, out var names) && names.Count > 0 ? names[0].String : null;
    public string? Weight => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_WEIGHT, out var names) && names.Count > 0 ? names[0].String : null;
    public string? Stretch => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_STRETCH, out var names) && names.Count > 0 ? names[0].String : null;
    public IReadOnlyList<string> DesignScriptLanguageTags => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_DESIGN_SCRIPT_LANGUAGE_TAG, out var names) ? names.Select(n => n.String).WhereNotNull().ToArray() : [];
    public IReadOnlyList<string> SupportedScriptLanguageTags => Properties.TryGetValue(DWRITE_FONT_PROPERTY_ID.DWRITE_FONT_PROPERTY_ID_SUPPORTED_SCRIPT_LANGUAGE_TAG, out var names) ? names.Select(n => n.String).WhereNotNull().ToArray() : [];

    public DateTime FileTime
    {
        get
        {
            NativeObject.GetFileTime(out var ft);
            return ft.ToDateTime();
        }
    }

    public virtual IComObject<IDWriteFontFile> GetFontFile()
    {
        NativeObject.GetFontFile(out var file).ThrowOnError();
        return new ComObject<IDWriteFontFile>(file);
    }

    public virtual IComObject<IDWriteFontFace3> CreateFontFace()
    {
        NativeObject.CreateFontFace(out var fontFace).ThrowOnError();
        return new ComObject<IDWriteFontFace3>(fontFace);
    }

    public virtual IComObject<IDWriteFontFace3> CreateFontFaceWithSimulations(DWRITE_FONT_SIMULATIONS simulations)
    {
        NativeObject.CreateFontFaceWithSimulations(simulations, out var fontFace).ThrowOnError();
        return new ComObject<IDWriteFontFace3>(fontFace);
    }

    public override string ToString() => FullName;
    public override bool Equals(object? obj) => Equals(obj as DWriteFont);
    public override int GetHashCode() => base.GetHashCode();
    public bool Equals(DWriteFont? other)
    {
        if (other == null)
            return false;

        return NativeObject.Equals(other.NativeObject);
    }
}
