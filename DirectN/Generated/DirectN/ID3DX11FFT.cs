﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3dcsx/nn-d3dcsx-id3dx11fft
[GeneratedComInterface, Guid("b3f7a938-4c93-4310-a675-b30d6de50553")]
public partial interface ID3DX11FFT
{
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-setforwardscale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetForwardScale(float ForwardScale);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-getforwardscale
    [PreserveSig]
    float GetForwardScale();
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-setinversescale
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInverseScale(float InverseScale);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-getinversescale
    [PreserveSig]
    float GetInverseScale();
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-attachbuffersandprecompute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AttachBuffersAndPrecompute(uint NumTempBuffers, [In][MarshalUsing(CountElementName = nameof(NumTempBuffers))] ID3D11UnorderedAccessView[] ppTempBuffers, uint NumPrecomputeBuffers, [In][MarshalUsing(CountElementName = nameof(NumPrecomputeBuffers))] ID3D11UnorderedAccessView[] ppPrecomputeBufferSizes);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-forwardtransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ForwardTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11UnorderedAccessView>))] ID3D11UnorderedAccessView pInputBuffer, ref ID3D11UnorderedAccessView ppOutputBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/d3dcsx/nf-d3dcsx-id3dx11fft-inversetransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT InverseTransform([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ID3D11UnorderedAccessView>))] ID3D11UnorderedAccessView pInputBuffer, ref ID3D11UnorderedAccessView ppOutputBuffer);
}
