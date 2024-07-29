#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmvideoforcekeyframe
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("9f8496be-5b9a-41b9-a9e8-f21cd80596c2")]
public partial interface IWMVideoForceKeyFrame
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmvideoforcekeyframe-setkeyframe
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetKeyFrame();
}
