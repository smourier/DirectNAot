#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfmuxstreammediatypemanager
[SupportedOSPlatform("windows10.0.15063")]
[GeneratedComInterface, Guid("505a2c72-42f7-4690-aeab-8f513d0ffdb8")]
public partial interface IMFMuxStreamMediaTypeManager
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pdwMuxStreamCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-getmediatype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMediaType(uint dwMuxStreamIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFMediaType>))] out IMFMediaType ppMediaType);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-getstreamconfigurationcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamConfigurationCount(out uint pdwCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-addstreamconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStreamConfiguration(ulong ullStreamMask);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-removestreamconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamConfiguration(ulong ullStreamMask);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfmuxstreammediatypemanager-getstreamconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamConfiguration(uint ulIndex, out ulong pullStreamMask);
}
