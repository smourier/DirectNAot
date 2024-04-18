namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_3/nn-dwrite_3-idwritetextlayout4
[GeneratedComInterface, Guid("05a9bf42-223f-4441-b5fb-8263685f55e9")]
public partial interface IDWriteTextLayout4 : IDWriteTextLayout3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetFontAxisValues(in DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount, DWRITE_TEXT_RANGE textRange);
    
    [PreserveSig]
    public uint GetFontAxisValueCount(uint currentPosition);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFontAxisValues(uint currentPosition, out DWRITE_FONT_AXIS_VALUE fontAxisValues, uint fontAxisValueCount, nint/* nint */ textRange);
    
    [PreserveSig]
    public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);
}
