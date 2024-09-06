#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmwriterfilesink2
[GeneratedComInterface, Guid("14282ba7-4aef-4205-8ce5-c229035a05bc")]
public partial interface IWMWriterFileSink2 : IWMWriterFileSink
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(ulong cnsStartTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop(ulong cnsStopTime);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-isstopped
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsStopped(out BOOL pfStopped);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-getfileduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileDuration(out ulong pcnsDuration);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-getfilesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFileSize(out ulong pcbFile);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmwriterfilesink2-isclosed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsClosed(out BOOL pfClosed);
}
