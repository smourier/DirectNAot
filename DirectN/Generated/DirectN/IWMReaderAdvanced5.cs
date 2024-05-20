#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced5
[GeneratedComInterface, Guid("24c44db0-55d1-49ae-a5cc-f13815e36363")]
public partial interface IWMReaderAdvanced5 : IWMReaderAdvanced4
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced5-setplayerhook
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayerHook(uint dwOutputNum, IWMPlayerHook pHook);
}
