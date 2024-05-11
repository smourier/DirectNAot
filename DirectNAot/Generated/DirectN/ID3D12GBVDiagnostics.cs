﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("597985ab-9b75-4dbb-be23-0761195bebee")]
public partial interface ID3D12GBVDiagnostics
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGBVEntireSubresourceStatesData(ID3D12Resource pResource, out int pData, uint DataSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGBVSubresourceState(ID3D12Resource pResource, uint Subresource, out int pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGBVResourceUniformState(ID3D12Resource pResource, out int pData);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGBVResourceInfo(ID3D12Resource pResource, nint /* optional D3D12_RESOURCE_DESC* */ pResourceDesc, nint /* optional uint* */ pResourceHash, nint /* optional uint* */ pSubresourceStatesByteOffset);
    
    [PreserveSig]
    void GBVReserved0();
    
    [PreserveSig]
    void GBVReserved1();
}
