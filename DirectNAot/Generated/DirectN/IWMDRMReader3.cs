namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmreader3
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("e08672de-f1e7-4ff4-a0a3-fc4b08e4caf8")]
public partial interface IWMDRMReader3 : IWMDRMReader2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmreader3-getinclusionlist
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInclusionList(out nint ppGuids, out uint pcGuids);
}
