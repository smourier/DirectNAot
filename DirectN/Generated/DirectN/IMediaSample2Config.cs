#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-imediasample2config
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("68961e68-832b-41ea-bc91-63593f3e70e3")]
public partial interface IMediaSample2Config
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-imediasample2config-getsurface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSurface(out nint ppDirect3DSurface9);
}
