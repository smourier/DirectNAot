namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/nn-mfsharingengine-iplaytocontrolwithcapabilities
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("aa9dd80f-c50a-4220-91c1-332287f82a34")]
public partial interface IPlayToControlWithCapabilities : IPlayToControl
{
    // https://learn.microsoft.com/windows/win32/api/mfsharingengine/nf-mfsharingengine-iplaytocontrolwithcapabilities-getcapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCapabilities(out PLAYTO_SOURCE_CREATEFLAGS pCapabilities);
}
