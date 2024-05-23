#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcontainer/nn-wmcontainer-imfasfmutualexclusion
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("12558291-e399-11d5-bc2a-00b0d0f3f4ab")]
public partial interface IMFASFMutualExclusion
{
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-gettype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetType(out Guid pguidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-settype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetType(in Guid guidType);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-getrecordcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordCount(out uint pdwRecordCount);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-getstreamsforrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamsForRecord(uint dwRecordNumber, out ushort pwStreamNumArray, ref uint pcStreams);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-addstreamforrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStreamForRecord(uint dwRecordNumber, ushort wStreamNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-removestreamfromrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamFromRecord(uint dwRecordNumber, ushort wStreamNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-removerecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveRecord(uint dwRecordNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-addrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddRecord(out uint pdwRecordNumber);
    
    // https://learn.microsoft.com/windows/win32/api/wmcontainer/nf-wmcontainer-imfasfmutualexclusion-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFASFMutualExclusion>))] out IMFASFMutualExclusion ppIMutex);
}
