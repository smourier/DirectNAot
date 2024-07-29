#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmplayerhook
[GeneratedComInterface, Guid("e5b7ca9a-0f1c-4f66-9002-74ec50d8b304")]
public partial interface IWMPlayerHook
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmplayerhook-predecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PreDecode();
}
