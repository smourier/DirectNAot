#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpskinmanager
[GeneratedComInterface, Guid("076f2fa6-ed30-448b-8cc5-3f3ef3529c7a")]
public partial interface IWMPSkinManager
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpskinmanager-setvisualstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetVisualStyle(BSTR bstrPath);
}
