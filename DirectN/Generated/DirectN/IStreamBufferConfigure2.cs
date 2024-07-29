#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambufferconfigure2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("53e037bf-3992-4282-ae34-2487b4dae06b")]
public partial interface IStreamBufferConfigure2 : IStreamBufferConfigure
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure2-setmultiplexedpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMultiplexedPacketSize(uint cbBytesPerPacket);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure2-getmultiplexedpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMultiplexedPacketSize(out uint pcbBytesPerPacket);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure2-setfftransitionrates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFFTransitionRates(uint dwMaxFullFrameRate, uint dwMaxNonSkippingRate);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambufferconfigure2-getfftransitionrates
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFFTransitionRates(out uint pdwMaxFullFrameRate, out uint pdwMaxNonSkippingRate);
}
