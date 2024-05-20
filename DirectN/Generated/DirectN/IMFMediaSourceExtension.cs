﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfmediasourceextension
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e467b94e-a713-4562-a802-816a42e9008a")]
public partial interface IMFMediaSourceExtension
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-getsourcebuffers
    [PreserveSig]
    IMFSourceBufferList GetSourceBuffers();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-getactivesourcebuffers
    [PreserveSig]
    IMFSourceBufferList GetActiveSourceBuffers();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-getreadystate
    [PreserveSig]
    MF_MSE_READY GetReadyState();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-getduration
    [PreserveSig]
    double GetDuration();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-setduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDuration(double duration);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-addsourcebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddSourceBuffer(BSTR type, IMFSourceBufferNotify pNotify, out IMFSourceBuffer ppSourceBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-removesourcebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveSourceBuffer(IMFSourceBuffer pSourceBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-setendofstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEndOfStream(MF_MSE_ERROR error);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-istypesupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool IsTypeSupported(BSTR type);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfmediasourceextension-getsourcebuffer
    [PreserveSig]
    IMFSourceBuffer GetSourceBuffer(uint dwStreamIndex);
}