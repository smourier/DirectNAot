namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-irunningobjecttable
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000010-0000-0000-c000-000000000046")]
public partial interface IRunningObjectTable
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-register
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Register(ROT_FLAGS grfFlags, nint punkObject, IMoniker pmkObjectName, out uint pdwRegister);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-revoke
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revoke(uint dwRegister);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-isrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsRunning(IMoniker pmkObjectName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-getobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetObject(IMoniker pmkObjectName, out nint ppunkObject);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-notechangetime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NoteChangeTime(uint dwRegister, in FILETIME pfiletime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-gettimeoflastchange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeOfLastChange(IMoniker pmkObjectName, out FILETIME pfiletime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-irunningobjecttable-enumrunning
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumRunning(out IEnumMoniker ppenumMoniker);
}
