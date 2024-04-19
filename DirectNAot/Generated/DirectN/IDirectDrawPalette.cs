namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ddraw/nn-ddraw-idirectdrawpalette
[GeneratedComInterface, Guid("6c14db84-a733-11ce-a521-0020af0be560")]
public partial interface IDirectDrawPalette
{
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawpalette-getcaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCaps(ref uint param0);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawpalette-getentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEntries(uint param0, uint param1, uint param2, ref PALETTEENTRY param3);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawpalette-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IDirectDraw param0, uint param1, ref PALETTEENTRY param2);
    
    // https://learn.microsoft.com/windows/win32/api/ddraw/nf-ddraw-idirectdrawpalette-setentries
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEntries(uint param0, uint param1, uint param2, ref PALETTEENTRY param3);
}
