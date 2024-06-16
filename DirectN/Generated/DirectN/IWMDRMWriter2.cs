#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmwriter2
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("38ee7a94-40e2-4e10-aa3f-33fd3210ed5b")]
public partial interface IWMDRMWriter2 : IWMDRMWriter
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter2-setwmdrmnetencryption
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetWMDRMNetEncryption(BOOL fSamplesEncrypted, nint /* byte array */ pbKeyID, uint cbKeyID);
}
