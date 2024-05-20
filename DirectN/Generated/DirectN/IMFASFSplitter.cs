#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfsplitter
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("12558295-e399-11d5-bc2a-00b0d0f3f4ab")]
public partial interface IMFASFSplitter
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(IMFASFContentInfo pIContentInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-setflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFlags(uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags(out uint pdwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-selectstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SelectStreams(in ushort pwStreamNumbers, ushort wNumStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-getselectedstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSelectedStreams(out ushort pwStreamNumbers, ref ushort pwNumStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-parsedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ParseData(IMFMediaBuffer pIBuffer, uint cbBufferOffset, uint cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-getnextsample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextSample(out ASF_STATUSFLAGS pdwStatusFlags, out ushort pwStreamNumber, out IMFSample ppISample);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-flush
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Flush();
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfsplitter-getlastsendtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastSendTime(out uint pdwLastSendTime);
}
