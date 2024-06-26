﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidlbase/nn-objidlbase-imalloc
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("00000002-0000-0000-c000-000000000046")]
public partial interface IMalloc
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-imalloc-alloc
    [PreserveSig]
    nint Alloc(nuint cb);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-realloc
    [PreserveSig]
    nint Realloc(nint /* optional void* */ pv, nuint cb);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-free
    [PreserveSig]
    void Free(nint /* optional void* */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-getsize
    [PreserveSig]
    nuint GetSize(nint /* optional void* */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-didalloc
    [PreserveSig]
    int DidAlloc(nint /* optional void* */ pv);
    
    // https://learn.microsoft.com/windows/win32/api/objidlbase/nf-objidlbase-imalloc-heapminimize
    [PreserveSig]
    void HeapMinimize();
}
