﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wincodec/nn-wincodec-iwicddsdecoder
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("409cd537-8532-40cb-9774-e2feb2df4e9c")]
public partial interface IWICDdsDecoder
{
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsdecoder-getparameters
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetParameters(out WICDdsParameters pParameters);
    
    // https://learn.microsoft.com/windows/win32/api/wincodec/nf-wincodec-iwicddsdecoder-getframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, out IWICBitmapFrameDecode ppIBitmapFrame);
}
