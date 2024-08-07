﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxgi/nn-dxgi-idxgifactory
[GeneratedComInterface, Guid("7b7166ec-21c7-44ae-b21a-c9ae321ae369")]
public partial interface IDXGIFactory : IDXGIObject
{
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-enumadapters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumAdapters(uint Adapter, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter>))] out IDXGIAdapter ppAdapter);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-makewindowassociation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MakeWindowAssociation(HWND WindowHandle, DXGI_MWA_FLAGS Flags);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-getwindowassociation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWindowAssociation(out HWND pWindowHandle);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-createswapchain
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSwapChain(nint pDevice, in DXGI_SWAP_CHAIN_DESC pDesc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGISwapChain>))] out IDXGISwapChain ppSwapChain);
    
    // https://learn.microsoft.com/windows/win32/api/dxgi/nf-dxgi-idxgifactory-createsoftwareadapter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateSoftwareAdapter(HMODULE Module, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDXGIAdapter>))] out IDXGIAdapter ppAdapter);
}
