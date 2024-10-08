﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12graphicscommandlist3
[GeneratedComInterface, Guid("6fda83a7-b84c-4e38-9ac8-c7bd22016b3d")]
public partial interface ID3D12GraphicsCommandList3 : ID3D12GraphicsCommandList2
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12graphicscommandlist3-setprotectedresourcesession
    [PreserveSig]
    void SetProtectedResourceSession([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D12ProtectedResourceSession?>))] ID3D12ProtectedResourceSession? pProtectedResourceSession);
}
