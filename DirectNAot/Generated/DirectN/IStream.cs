namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-istream
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("0000000c-0000-0000-c000-000000000046")]
public partial interface IStream : ISequentialStream
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-seek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Seek(long dlibMove, STREAM_SEEK dwOrigin, nint/* nint */ plibNewPosition);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT SetSize(ulong libNewSize);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-copyto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CopyTo(IStream pstm, ulong cb, nint/* nint */ pcbRead, nint/* nint */ pcbWritten);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-commit
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Commit(uint grfCommitFlags);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-revert
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Revert();
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-lockregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT LockRegion(ulong libOffset, ulong cb, uint dwLockType);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-unlockregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UnlockRegion(ulong libOffset, ulong cb, uint dwLockType);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-stat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Stat(out STATSTG pstatstg, uint grfStatFlag);
    
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-istream-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Clone(out IStream ppstm);
}
