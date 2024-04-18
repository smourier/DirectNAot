namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritefontface5
[GeneratedComInterface, Guid("98eff3a5-b667-479a-b145-e2fa5b9fdc29")]
public partial interface IDWriteFontFace5 : IDWriteFontFace4
{
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface5-getfontaxisvaluecount
    [PreserveSig]
    public uint GetFontAxisValueCount();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface5-getfontaxisvalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontAxisValues(out DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface5-hasvariations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool HasVariations();
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface5-getfontresource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontResource(out IDWriteFontResource fontResource);
    
    // https://learn.microsoft.com/windows/win32/api/dwrite_3/nf-dwrite_3-idwritefontface5-equals
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool Equals(IDWriteFontFace fontFace);
}
