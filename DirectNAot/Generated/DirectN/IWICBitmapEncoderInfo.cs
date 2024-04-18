namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicbitmapencoderinfo
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("94c9b4ee-a09f-4f92-8a1e-4a9bce7e76fb")]
public partial interface IWICBitmapEncoderInfo : IWICBitmapCodecInfo
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicbitmapencoderinfo-createinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateInstance(out IWICBitmapEncoder ppIBitmapEncoder);
}
