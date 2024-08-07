﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d9/nn-d3d9-idirect3dresource9
[GeneratedComInterface, Guid("05eec05d-8f7d-4362-b999-d1baf357c704")]
public partial interface IDirect3DResource9
{
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirect3DDevice9>))] out IDirect3DDevice9 ppDevice);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-setprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrivateData(in Guid refguid, nint pData, uint SizeOfData, uint Flags);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(in Guid refguid, nint pData, ref uint pSizeOfData);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-freeprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FreePrivateData(in Guid refguid);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-setpriority
    [PreserveSig]
    uint SetPriority(uint PriorityNew);
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-getpriority
    [PreserveSig]
    uint GetPriority();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-preload
    [PreserveSig]
    void PreLoad();
    
    // https://learn.microsoft.com/windows/win32/api/d3d9/nf-d3d9-idirect3dresource9-gettype
    [PreserveSig]
    D3DRESOURCETYPE GetType();
}
