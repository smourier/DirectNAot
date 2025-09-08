#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-istorage
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000b-0000-0000-c000-000000000046")]
public partial interface IStorage
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-createstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStream(PWSTR pwcsName, STGM grfMode, uint reserved1, uint reserved2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstm);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-openstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenStream(PWSTR pwcsName, nint /* optional void* */ reserved1, STGM grfMode, uint reserved2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstm);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-createstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateStorage(PWSTR pwcsName, STGM grfMode, uint reserved1, uint reserved2, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] out IStorage ppstg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-openstorage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenStorage(PWSTR pwcsName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pstgPriority, STGM grfMode, in ushort snbExclude, uint reserved, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] out IStorage ppstg);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-copyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyTo(uint ciidExclude, nint /* optional Guid* */ rgiidExclude, nint /* optional ushort** */ snbExclude, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pstgDest);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-moveelementto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MoveElementTo(PWSTR pwcsName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStorage>))] IStorage pstgDest, PWSTR pwcsNewName, uint grfFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit(uint grfCommitFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revert();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-enumelements
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumElements(uint reserved1, nint /* optional void* */ reserved2, uint reserved3, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumSTATSTG>))] out IEnumSTATSTG ppenum);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-destroyelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DestroyElement(PWSTR pwcsName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-renameelement
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenameElement(PWSTR pwcsOldName, PWSTR pwcsNewName);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setelementtimes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetElementTimes(PWSTR pwcsName, in FILETIME pctime, in FILETIME patime, in FILETIME pmtime);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setclass
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetClass(in Guid clsid);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-setstatebits
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStateBits(uint grfStateBits, uint grfMask);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istorage-stat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stat(out STATSTG pstatstg, uint grfStatFlag);
}
