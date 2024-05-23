#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-istream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000c-0000-0000-c000-000000000046")]
public partial interface IStream : ISequentialStream
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(long dlibMove, STREAM_SEEK dwOrigin, nint /* optional ulong* */ plibNewPosition);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSize(ulong libNewSize);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-copyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CopyTo(IStream pstm, ulong cb, nint /* optional ulong* */ pcbRead, nint /* optional ulong* */ pcbWritten);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Commit(uint grfCommitFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Revert();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-lockregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT LockRegion(ulong libOffset, ulong cb, uint dwLockType);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-unlockregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-stat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stat(out STATSTG pstatstg, uint grfStatFlag);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] out IStream ppstm);
}
