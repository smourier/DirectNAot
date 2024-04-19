namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclock2
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("6f49ff73-6727-49ac-a008-d98cf5e70048")]
public partial interface IAudioClock2
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclock2-getdeviceposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevicePosition(out ulong DevicePosition, nint/* nint */ QPCPosition);
}
