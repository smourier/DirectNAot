namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmap
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00000121-a8f2-4877-ba0a-fd2b6645fb94")]
public partial interface IWICBitmap : IWICBitmapSource
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmap-lock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Lock(in WICRect prcLock, uint flags, out IWICBitmapLock ppILock);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmap-setpalette
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetPalette(IWICPalette pIPalette);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmap-setresolution
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetResolution(double dpiX, double dpiY);
}
