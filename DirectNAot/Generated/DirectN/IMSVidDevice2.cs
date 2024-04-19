namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsviddevice2
[GeneratedComInterface, Guid("87bd2783-ebc0-478c-b4a0-e8e7f43ab78e")]
public partial interface IMSVidDevice2
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsviddevice2-get_devicepath
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DevicePath(out BSTR DevPath);
}
