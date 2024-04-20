namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapcodecprogressnotification
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("64c1024e-c3cf-4462-8078-88c2b11c46d9")]
public partial interface IWICBitmapCodecProgressNotification
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapcodecprogressnotification-registerprogressnotification
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterProgressNotification(PFNProgressNotification pfnProgressNotification, nint /* optional void */ pvData, uint dwProgressFlags);
}
