﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11_1/nn-d3d11_1-id3d11device1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a04bfb29-08ef-43d6-a49c-a9bdbdcbe686")]
public partial interface ID3D11Device1 : ID3D11Device
{
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-getimmediatecontext1
    [PreserveSig]
    public void GetImmediateContext1(out ID3D11DeviceContext1 ppImmediateContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-createdeferredcontext1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeferredContext1(uint ContextFlags, nint/* nint */ ppDeferredContext);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-createblendstate1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateBlendState1(in D3D11_BLEND_DESC1 pBlendStateDesc, nint/* nint */ ppBlendState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-createrasterizerstate1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateRasterizerState1(in D3D11_RASTERIZER_DESC1 pRasterizerDesc, nint/* nint */ ppRasterizerState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-createdevicecontextstate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateDeviceContextState(uint Flags, in D3D_FEATURE_LEVEL pFeatureLevels, uint FeatureLevels, uint SDKVersion, in Guid EmulatedInterface, nint/* nint */ pChosenFeatureLevel, nint/* nint */ ppContextState);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-opensharedresource1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OpenSharedResource1(HANDLE hResource, in Guid returnedInterface, out nint ppResource);
    
    // https://learn.microsoft.com/windows/win32/api/d3d11_1/nf-d3d11_1-id3d11device1-opensharedresourcebyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT OpenSharedResourceByName(PWSTR lpName, uint dwDesiredAccess, in Guid returnedInterface, out nint ppResource);
}
