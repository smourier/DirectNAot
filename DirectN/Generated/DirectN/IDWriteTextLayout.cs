#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextlayout
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("53737037-6d14-410b-9bfe-0b182bb70961")]
public partial interface IDWriteTextLayout : IDWriteTextFormat
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setmaxwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxWidth(float maxWidth);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setmaxheight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMaxHeight(float maxHeight);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontCollection([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection>))] IDWriteFontCollection fontCollection, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontfamilyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontFamilyName(PWSTR fontFamilyName, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontweight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontstretch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setfontsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setdrawingeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDrawingEffect(nint drawingEffect, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInlineObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteInlineObject>))] IDWriteInlineObject inlineObject, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-settypography
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTypography([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTypography>))] IDWriteTypography typography, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-setlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLocaleName(PWSTR localeName, DWRITE_TEXT_RANGE textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getmaxwidth
    [PreserveSig]
    float GetMaxWidth();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getmaxheight
    [PreserveSig]
    float GetMaxHeight();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontCollection(uint currentPosition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontCollection>))] out IDWriteFontCollection fontCollection, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontfamilynamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamilyNameLength(uint currentPosition, out uint nameLength, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontfamilyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamilyName(uint currentPosition, [MarshalUsing(CountElementName = nameof(nameSize))] PWSTR fontFamilyName, uint nameSize, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontweight
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontWeight(uint currentPosition, out DWRITE_FONT_WEIGHT fontWeight, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontStyle(uint currentPosition, out DWRITE_FONT_STYLE fontStyle, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontstretch
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontStretch(uint currentPosition, out DWRITE_FONT_STRETCH fontStretch, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getfontsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontSize(uint currentPosition, out float fontSize, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getunderline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnderline(uint currentPosition, out BOOL hasUnderline, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getstrikethrough
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStrikethrough(uint currentPosition, out BOOL hasStrikethrough, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getdrawingeffect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDrawingEffect(uint currentPosition, out nint drawingEffect, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getinlineobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInlineObject(uint currentPosition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteInlineObject>))] out IDWriteInlineObject inlineObject, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-gettypography
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTypography(uint currentPosition, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTypography>))] out IDWriteTypography typography, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getlocalenamelength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleNameLength(uint currentPosition, out uint nameLength, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleName(uint currentPosition, [MarshalUsing(CountElementName = nameof(nameSize))] PWSTR localeName, uint nameSize, nint /* optional DWRITE_TEXT_RANGE* */ textRange);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-draw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Draw(nint /* optional void* */ clientDrawingContext, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteTextRenderer>))] IDWriteTextRenderer renderer, float originX, float originY);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getlinemetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineMetrics(nint /* optional DWRITE_LINE_METRICS* */ lineMetrics, uint maxLineCount, out uint actualLineCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMetrics(out DWRITE_TEXT_METRICS textMetrics);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout-getoverhangmetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOverhangMetrics(out DWRITE_OVERHANG_METRICS overhangs);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-getclustermetrics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClusterMetrics(nint /* optional DWRITE_CLUSTER_METRICS* */ clusterMetrics, uint maxClusterCount, out uint actualClusterCount);
    
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextlayout-determineminwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DetermineMinWidth(out float minWidth);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-hittestpoint
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HitTestPoint(float pointX, float pointY, out BOOL isTrailingHit, out BOOL isInside, out DWRITE_HIT_TEST_METRICS hitTestMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-hittesttextposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HitTestTextPosition(uint textPosition, BOOL isTrailingHit, out float pointX, out float pointY, out DWRITE_HIT_TEST_METRICS hitTestMetrics);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextlayout-hittesttextrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT HitTestTextRange(uint textPosition, uint textLength, float originX, float originY, nint /* optional DWRITE_HIT_TEST_METRICS* */ hitTestMetrics, uint maxHitTestMetricsCount, out uint actualHitTestMetricsCount);
}
