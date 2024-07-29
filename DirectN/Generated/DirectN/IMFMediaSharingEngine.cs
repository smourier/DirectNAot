#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-imfmediasharingengine
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("8d3ce1bf-2367-40e0-9eee-40d377cc1b46")]
public partial interface IMFMediaSharingEngine : IMFMediaEngine
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-imfmediasharingengine-getdevice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevice(out DEVICE_INFO pDevice);
}
