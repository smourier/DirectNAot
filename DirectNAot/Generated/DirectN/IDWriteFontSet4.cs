﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontset4
[GeneratedComInterface, Guid("eec175fc-bea9-4c86-8b53-ccbdd7df0c82")]
public partial interface IDWriteFontSet4 : IDWriteFontSet3
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset4-convertweightstretchstyletofontaxisvalues
    [PreserveSig]
    uint ConvertWeightStretchStyleToFontAxisValues(nint /* optional DWRITE_FONT_AXIS_VALUE* */ inputAxisValues, uint inputAxisCount, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, float fontSize, [MarshalUsing(ConstantElementCount = 5)] out DWRITE_FONT_AXIS_VALUE[] outputAxisValues);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontset4-getmatchingfonts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMatchingFonts(PWSTR familyName, [MarshalUsing(CountElementName = nameof(fontAxisValueCount))] in DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount, DWRITE_FONT_SIMULATIONS allowedSimulations, out IDWriteFontSet4 matchingFonts);
}
