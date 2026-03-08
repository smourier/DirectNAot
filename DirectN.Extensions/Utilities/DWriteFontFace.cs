namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows6.1")]
public class DWriteFontFace(IComObject<IDWriteFontFace> face) : InterlockedComObject<IDWriteFontFace>(face), IEquatable<DWriteFontFace>
{
    public DWRITE_FONT_FACE_TYPE Type => NativeObject.GetType();
    public uint Index => NativeObject.GetIndex();
    public DWRITE_FONT_SIMULATIONS Simulations => NativeObject.GetSimulations();
    public DWRITE_FONT_METRICS Metrics { get { NativeObject.GetMetrics(out var metrics); return metrics; } }
    public uint GlyphCount => NativeObject.GetGlyphCount();

    [SupportedOSPlatform("windows8.0")]
    public DWRITE_FONT_METRICS1 Metrics1
    {
        get
        {
            if (NativeObject is IDWriteFontFace1 face)
            {
                face.GetMetrics(out DWRITE_FONT_METRICS1 metrics);
                return metrics;
            }
            return new();
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public DWRITE_CARET_METRICS CaretMetrics
    {
        get
        {
            if (NativeObject is IDWriteFontFace1 face)
            {
                face.GetCaretMetrics(out DWRITE_CARET_METRICS metrics);
                return metrics;
            }
            return new();
        }
    }

    [SupportedOSPlatform("windows8.1")]
    public uint ColorPaletteCount
    {
        get
        {
            if (NativeObject is IDWriteFontFace2 face)
                return face.GetColorPaletteCount();

            return 0;
        }
    }

    [SupportedOSPlatform("windows8.1")]
    public uint PaletteEntryCount
    {
        get
        {
            if (NativeObject is IDWriteFontFace2 face)
                return face.GetPaletteEntryCount();

            return 0;
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public bool IsMonospacedFont
    {
        get
        {
            if (NativeObject is IDWriteFontFace1 face)
                return face.IsMonospacedFont();

            return false;
        }
    }

    [SupportedOSPlatform("windows8.1")]
    public bool IsColorFont
    {
        get
        {
            if (NativeObject is IDWriteFontFace2 face)
                return face.IsColorFont();

            return false;
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public bool HasKerningPairs
    {
        get
        {
            if (NativeObject is IDWriteFontFace1 face)
                return face.HasKerningPairs();

            return false;
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public bool HasVerticalGlyphVariants
    {
        get
        {
            if (NativeObject is IDWriteFontFace1 face)
                return face.HasVerticalGlyphVariants();

            return false;
        }
    }

    public bool HasVariations
    {
        get
        {
            if (NativeObject is IDWriteFontFace5 face)
                return face.HasVariations();

            return false;
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public DWRITE_PANOSE Panose
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
            {
                face.GetPanose(out var panose);
                return panose;
            }

            return new();
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public DWRITE_FONT_WEIGHT Weight
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
                return face.GetWeight();

            return DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL;
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public DWRITE_FONT_STRETCH Stretch
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
                return face.GetStretch();

            return DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL;
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public DWRITE_FONT_STYLE Style
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
                return face.GetStyle();

            return DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL;
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public DWRITE_GLYPH_IMAGE_FORMATS GlyphImageFormats
    {
        get
        {
            if (NativeObject is IDWriteFontFace4 face)
                return face.GetGlyphImageFormats();

            return DWRITE_GLYPH_IMAGE_FORMATS.DWRITE_GLYPH_IMAGE_FORMATS_NONE;
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public IReadOnlyList<DWriteLocalizedString> Names
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
            {
                face.GetFaceNames(out var strings);
                return strings.GetNames();
            }

            return [];
        }
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public IReadOnlyList<DWriteLocalizedString> FamilyNames
    {
        get
        {
            if (NativeObject is IDWriteFontFace3 face)
            {
                face.GetFamilyNames(out var strings);
                return strings.GetNames();
            }

            return [];
        }
    }

    [SupportedOSPlatform("windows8.0")]
    public IReadOnlyList<DWRITE_UNICODE_RANGE> GetUnicodeRanges()
    {
        if (NativeObject is not IDWriteFontFace1 face1)
            return [];

        face1.GetUnicodeRanges(0, 0, out var actualCount);
        var ranges = new DWRITE_UNICODE_RANGE[actualCount];
        unsafe
        {
            fixed (DWRITE_UNICODE_RANGE* pRanges = ranges)
            {
                face1.GetUnicodeRanges((uint)ranges.Length, (IntPtr)pRanges, out _);
            }
        }
        return ranges;
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public IReadOnlyList<DWriteLocalizedString> GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID id)
    {
        if (NativeObject is IDWriteFontFace3 face)
        {
            face.GetInformationalStrings(id, out var strings, out var _);
            return strings.GetNames();
        }
        return [];
    }

    public IReadOnlyList<DWriteLocalizedString> GetFamilyNames(DWRITE_FONT_FAMILY_MODEL model)
    {
        if (NativeObject is IDWriteFontFace6 face)
        {
            face.GetFamilyNames(model, out var strings);
            return strings.GetNames();
        }

        return [];
    }

    public IReadOnlyList<DWriteLocalizedString> GetFaceNames(DWRITE_FONT_FAMILY_MODEL model)
    {
        if (NativeObject is IDWriteFontFace6 face)
        {
            face.GetFaceNames(model, out var strings);
            return strings.GetNames();
        }

        return [];
    }

    public DWRITE_PAINT_FEATURE_LEVEL GetPaintFeatureLevel(DWRITE_GLYPH_IMAGE_FORMATS formats)
    {
        if (NativeObject is IDWriteFontFace7 face)
            return face.GetPaintFeatureLevel(formats);

        return DWRITE_PAINT_FEATURE_LEVEL.DWRITE_PAINT_FEATURE_LEVEL_NONE;
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public bool? HasCharacter(uint unicodeValue)
    {
        if (NativeObject is IDWriteFontFace3 face)
            return face.HasCharacter(unicodeValue);

        return null;
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public bool? IsCharacterLocal(uint unicodeValue)
    {
        if (NativeObject is IDWriteFontFace3 face)
            return face.IsCharacterLocal(unicodeValue);

        return null;
    }

    [SupportedOSPlatform("windows10.0.10240")]
    public bool? IsGlyphLocal(ushort glyphId)
    {
        if (NativeObject is IDWriteFontFace3 face)
            return face.IsGlyphLocal(glyphId);

        return null;
    }

    public override bool Equals(object? obj) => Equals(obj as DWriteFont);
    public override int GetHashCode() => base.GetHashCode();
    public bool Equals(DWriteFontFace? other)
    {
        if (other == null)
            return false;

        if (NativeObject is IDWriteFontFace5 face5)
            return face5.Equals(other.NativeObject);

        return NativeObject.Equals(other.NativeObject);
    }
}
