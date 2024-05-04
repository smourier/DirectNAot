#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-istreambuffermediaseeking2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("3a439ab0-155f-470a-86a6-9ea54afd6eaf")]
public partial interface IStreamBufferMediaSeeking2 : IStreamBufferMediaSeeking
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-istreambuffermediaseeking2-setrateex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRateEx(double dRate, uint dwFramesPerSec);
}
