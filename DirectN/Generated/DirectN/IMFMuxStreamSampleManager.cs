#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmuxstreamsamplemanager
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("74abbc19-b1cc-4e41-bb8b-9d9b86a8f6ca")]
public partial interface IMFMuxStreamSampleManager
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreamsamplemanager-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pdwMuxStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreamsamplemanager-getsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSample(uint dwMuxStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFSample>))] out IMFSample ppSample);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreamsamplemanager-getstreamconfiguration
    [PreserveSig]
    ulong GetStreamConfiguration();
}
