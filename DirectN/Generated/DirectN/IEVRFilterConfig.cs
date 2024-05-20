#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/evr/nn-evr-ievrfilterconfig
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("83e91e85-82c1-4ea7-801d-85dc50b75086")]
public partial interface IEVRFilterConfig
{
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrfilterconfig-setnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetNumberOfStreams(uint dwMaxStreams);
    
    // https://learn.microsoft.com/windows/win32/api/evr/nf-evr-ievrfilterconfig-getnumberofstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfStreams(out uint pdwMaxStreams);
}
