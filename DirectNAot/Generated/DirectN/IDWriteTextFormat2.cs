namespace DirectN;

// https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextformat2
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f67e0edd-9e3d-4ecc-8c32-4183253dfe70")]
public partial interface IDWriteTextFormat2 : IDWriteTextFormat1
{
    // https://learn.microsoft.com/windows/win32/DirectWrite/idwritetextformat2-setlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLineSpacing(in DWRITE_LINE_SPACING lineSpacingOptions);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritetextformat2-getlinespacing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLineSpacing(out DWRITE_LINE_SPACING lineSpacingOptions);
}
