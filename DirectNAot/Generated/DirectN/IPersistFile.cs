namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-ipersistfile
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000010b-0000-0000-c000-000000000046")]
public partial interface IPersistFile : IPersist
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersistfile-isdirty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsDirty();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersistfile-load
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Load(PWSTR pszFileName, STGM dwMode);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersistfile-save
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Save(PWSTR pszFileName, [MarshalAs(UnmanagedType.U4)] bool fRemember);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersistfile-savecompleted
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveCompleted(PWSTR pszFileName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-ipersistfile-getcurfile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurFile(out PWSTR ppszFileName);
}
