#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmresamplerprops
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e7e9984f-f09f-4da4-903f-6e2e0efe56b5")]
public partial interface IWMResamplerProps
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresamplerprops-sethalffilterlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetHalfFilterLength(int lhalfFilterLen);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmresamplerprops-setuserchannelmtx
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUserChannelMtx(ref float userChannelMtx);
}
