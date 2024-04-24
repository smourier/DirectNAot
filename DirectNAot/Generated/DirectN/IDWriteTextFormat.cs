namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritetextformat
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("9c906818-31d7-4fd3-a151-7c5e225db55a")]
public partial interface IDWriteTextFormat
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-settextalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setparagraphalignment
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setwordwrapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setreadingdirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setflowdirection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setincrementaltabstop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetIncrementalTabStop(float incrementalTabStop);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-settrimming
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTrimming(in DWRITE_TRIMMING trimmingOptions, IDWriteInlineObject? trimmingSign);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-setlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-gettextalignment
    [PreserveSig]
    DWRITE_TEXT_ALIGNMENT GetTextAlignment();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getparagraphalignment
    [PreserveSig]
    DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getwordwrapping
    [PreserveSig]
    DWRITE_WORD_WRAPPING GetWordWrapping();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getreadingdirection
    [PreserveSig]
    DWRITE_READING_DIRECTION GetReadingDirection();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getflowdirection
    [PreserveSig]
    DWRITE_FLOW_DIRECTION GetFlowDirection();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getincrementaltabstop
    [PreserveSig]
    float GetIncrementalTabStop();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-gettrimming
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTrimming(out DWRITE_TRIMMING trimmingOptions, out IDWriteInlineObject trimmingSign);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineSpacing(out DWRITE_LINE_SPACING_METHOD lineSpacingMethod, out float lineSpacing, out float baseline);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontcollection
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontCollection(out IDWriteFontCollection fontCollection);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontfamilynamelength
    [PreserveSig]
    uint GetFontFamilyNameLength();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontfamilyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFontFamilyName([MarshalUsing(CountElementName = nameof(nameSize))] out PWSTR[] fontFamilyName, uint nameSize);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontweight
    [PreserveSig]
    DWRITE_FONT_WEIGHT GetFontWeight();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontstyle
    [PreserveSig]
    DWRITE_FONT_STYLE GetFontStyle();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontstretch
    [PreserveSig]
    DWRITE_FONT_STRETCH GetFontStretch();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getfontsize
    [PreserveSig]
    float GetFontSize();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getlocalenamelength
    [PreserveSig]
    uint GetLocaleNameLength();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritetextformat-getlocalename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocaleName([MarshalUsing(CountElementName = nameof(nameSize))] out PWSTR[] localeName, uint nameSize);
}
