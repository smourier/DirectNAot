#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/videoacc/nn-videoacc-iamvideoaccelerator
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("256a6a22-fbad-11d1-82bf-00a0c9696c8f")]
public partial interface IAMVideoAccelerator
{
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getvideoacceleratorguids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVideoAcceleratorGUIDs(ref uint pdwNumGuidsSupported, nint /* optional Guid* */ pGuidsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getuncompformatssupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUncompFormatsSupported(in Guid pGuid, ref uint pdwNumFormatsSupported, nint /* optional DDPIXELFORMAT* */ pFormatsSupported);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getinternalmeminfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInternalMemInfo(in Guid pGuid, in AMVAUncompDataInfo pamvaUncompDataInfo, ref AMVAInternalMemInfo pamvaInternalMemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getcompbufferinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompBufferInfo(in Guid pGuid, in AMVAUncompDataInfo pamvaUncompDataInfo, ref uint pdwNumTypesCompBuffers, nint /* optional AMVACompBufferInfo* */ pamvaCompBufferInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getinternalcompbufferinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInternalCompBufferInfo(ref uint pdwNumTypesCompBuffers, nint /* optional AMVACompBufferInfo* */ pamvaCompBufferInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-beginframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginFrame(in AMVABeginFrameInfo amvaBeginFrameInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-endframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndFrame(in AMVAEndFrameInfo pEndFrameInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(uint dwTypeIndex, uint dwBufferIndex, [MarshalAs(UnmanagedType.U4)] bool bReadOnly, out nint ppBuffer, out int lpStride);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-releasebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBuffer(uint dwTypeIndex, uint dwBufferIndex);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-execute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Execute(uint dwFunction, nint lpPrivateInputData, uint cbPrivateInputData, nint lpPrivateOutputDat, uint cbPrivateOutputData, uint dwNumBuffers, [In][MarshalUsing(CountElementName = nameof(dwNumBuffers))] AMVABUFFERINFO[] pamvaBufferInfo);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-queryrenderstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueryRenderStatus(uint dwTypeIndex, uint dwBufferIndex, uint dwFlags);
    
    // https://learn.microsoft.com/windows/win32/api/videoacc/nf-videoacc-iamvideoaccelerator-displayframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayFrame(uint dwFlipToIndex, IMediaSample pMediaSample);
}
