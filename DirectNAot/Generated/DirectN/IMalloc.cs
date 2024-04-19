namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-imalloc
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000002-0000-0000-c000-000000000046")]
public partial interface IMalloc
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imalloc-alloc
    [PreserveSig]
    void Alloc(nuint cb);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-realloc
    [PreserveSig]
    void Realloc(nint/* nint */ pv, nuint cb);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-free
    [PreserveSig]
    void Free(nint/* nint */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-getsize
    [PreserveSig]
    nuint GetSize(nint/* nint */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-didalloc
    [PreserveSig]
    int DidAlloc(nint/* nint */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-heapminimize
    [PreserveSig]
    void HeapMinimize();
}
