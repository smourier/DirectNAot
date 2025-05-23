﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10/nn-d3d10-id3d10multithread
[GeneratedComInterface, Guid("9b7e4e00-342c-4106-a19f-4f2704f689f0")]
public partial interface ID3D10Multithread
{
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10multithread-enter
    [PreserveSig]
    void Enter();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10multithread-leave
    [PreserveSig]
    void Leave();
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10multithread-setmultithreadprotected
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL SetMultithreadProtected(BOOL bMTProtect);
    
    // https://learn.microsoft.com/windows/win32/api/d3d10/nf-d3d10-id3d10multithread-getmultithreadprotected
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL GetMultithreadProtected();
}
