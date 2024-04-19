﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-iksformatsupport
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("3cb4a69d-bb6f-4d2b-95b7-452d2c155db5")]
public partial interface IKsFormatSupport
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksformatsupport-isformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsFormatSupported(ref KSDATAFORMAT pKsFormat, uint cbFormat, [MarshalAs(UnmanagedType.U4)] out bool pbSupported);
    
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-iksformatsupport-getdevicepreferredformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevicePreferredFormat(out KSDATAFORMAT ppKsFormat);
}
