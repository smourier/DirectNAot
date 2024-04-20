namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/devicetopology/nn-devicetopology-icontrolchangenotify
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("a09513ed-c709-4d21-bd7b-5f34c47f3947")]
public partial interface IControlChangeNotify
{
    // https://learn.microsoft.com/windows/win32/api/devicetopology/nf-devicetopology-icontrolchangenotify-onnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnNotify(uint dwSenderProcessId, nint /* optional Guid */ pguidEventContext);
}
