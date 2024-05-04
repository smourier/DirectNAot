#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfprofile
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("d267bf6a-028b-4e0d-903d-43f0ef82d0d4")]
public partial interface IMFASFProfile : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getstreamcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamCount(out uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStream(uint dwStreamIndex, out ushort pwStreamNumber, out IMFASFStreamConfig ppIStream);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getstreambynumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamByNumber(ushort wStreamNumber, out IMFASFStreamConfig ppIStream);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-setstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStream(IMFASFStreamConfig pIStream);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-removestream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStream(ushort wStreamNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-createstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStream(IMFMediaType pIMediaType, out IMFASFStreamConfig ppIStream);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getmutualexclusioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMutualExclusionCount(out uint pcMutexs);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMutualExclusion(uint dwMutexIndex, out IMFASFMutualExclusion ppIMutex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-addmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddMutualExclusion(IMFASFMutualExclusion pIMutex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-removemutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveMutualExclusion(uint dwMutexIndex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-createmutualexclusion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMutualExclusion(out IMFASFMutualExclusion ppIMutex);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-getstreamprioritization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamPrioritization(out IMFASFStreamPrioritization ppIStreamPrioritization);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-addstreamprioritization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStreamPrioritization(IMFASFStreamPrioritization pIStreamPrioritization);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-removestreamprioritization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamPrioritization();
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-createstreamprioritization
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStreamPrioritization(out IMFASFStreamPrioritization ppIStreamPrioritization);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfprofile-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out IMFASFProfile ppIProfile);
}
