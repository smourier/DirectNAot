namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-istorage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000b-0000-0000-c000-000000000046")]
public partial interface IStorage
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-createstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateStream(PWSTR pwcsName, STGM grfMode, uint reserved1, uint reserved2, out IStream ppstm);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-openstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OpenStream(PWSTR pwcsName, nint /* void */ reserved1, STGM grfMode, uint reserved2, out IStream ppstm);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-createstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateStorage(PWSTR pwcsName, STGM grfMode, uint reserved1, uint reserved2, out IStorage ppstg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-openstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OpenStorage(PWSTR pwcsName, IStorage pstgPriority, STGM grfMode, in ushort snbExclude, uint reserved, out IStorage ppstg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-copyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyTo(uint ciidExclude, nint /* Guid */ rgiidExclude, nint /* ushort */ snbExclude, IStorage pstgDest);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-moveelementto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT MoveElementTo(PWSTR pwcsName, IStorage pstgDest, PWSTR pwcsNewName, uint grfFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Commit(uint grfCommitFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Revert();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-enumelements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumElements(uint reserved1, nint /* void */ reserved2, uint reserved3, out IEnumSTATSTG ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-destroyelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT DestroyElement(PWSTR pwcsName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-renameelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RenameElement(PWSTR pwcsOldName, PWSTR pwcsNewName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setelementtimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetElementTimes(PWSTR pwcsName, in FILETIME pctime, in FILETIME patime, in FILETIME pmtime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetClass(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setstatebits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetStateBits(uint grfStateBits, uint grfMask);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-stat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Stat(out STATSTG pstatstg, uint grfStatFlag);
}
