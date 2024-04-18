﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgifactory1
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("770aae78-f26f-4dba-a829-253c83d1b387")]
public partial interface IDXGIFactory1 : IDXGIFactory
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory1-enumadapters1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT EnumAdapters1(uint Adapter, out IDXGIAdapter1 ppAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory1-iscurrent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    public bool IsCurrent();
}
