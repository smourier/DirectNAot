#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfplugincontrol2
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("c6982083-3ddc-45cb-af5e-0f7a8ce4de77")]
public partial interface IMFPluginControl2 : IMFPluginControl
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfplugincontrol2-setpolicy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPolicy(MF_PLUGIN_CONTROL_POLICY policy);
}
