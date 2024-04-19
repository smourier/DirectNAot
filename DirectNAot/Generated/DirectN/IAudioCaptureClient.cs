namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudiocaptureclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("c8adbd64-e71e-48a0-a4de-185c395cd317")]
public partial interface IAudioCaptureClient
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiocaptureclient-getbuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBuffer(out nint /* byte array */ ppData, out uint pNumFramesToRead, out uint pdwFlags, nint/* nint */ pu64DevicePosition, nint/* nint */ pu64QPCPosition);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiocaptureclient-releasebuffer
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseBuffer(uint NumFramesRead);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudiocaptureclient-getnextpacketsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextPacketSize(out uint pNumFramesInNextPacket);
}
