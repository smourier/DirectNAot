#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterfilesink3
[GeneratedComInterface, Guid("3fea4feb-2945-47a7-a1dd-c53a8fc4c45c")]
public partial interface IWMWriterFileSink3 : IWMWriterFileSink2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-setautoindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAutoIndexing(BOOL fDoAutoIndexing);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-getautoindexing
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAutoIndexing(out BOOL pfAutoIndexing);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-setcontrolstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetControlStream(ushort wStreamNumber, BOOL fShouldControlStartAndStop);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-getmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMode(out uint pdwFileSinkMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-ondataunitex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDataUnitEx(in WMT_FILESINK_DATA_UNIT pFileSinkDataUnit);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-setunbufferedio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUnbufferedIO(BOOL fUnbufferedIO, BOOL fRestrictMemUsage);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-getunbufferedio
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUnbufferedIO(out BOOL pfUnbufferedIO);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink3-completeoperations
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CompleteOperations();
}
