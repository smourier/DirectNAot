#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmclientconnections2
[GeneratedComInterface, Guid("4091571e-4701-4593-bb3d-d5f5f0c74246")]
public partial interface IWMClientConnections2 : IWMClientConnections
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmclientconnections2-getclientinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClientInfo(uint dwClientNum, [MarshalUsing(CountElementName = nameof(pcchNetworkAddress))] out PWSTR[] pwszNetworkAddress, ref uint pcchNetworkAddress, [MarshalUsing(CountElementName = nameof(pcchPort))] out PWSTR[] pwszPort, ref uint pcchPort, [MarshalUsing(CountElementName = nameof(pcchDNSName))] out PWSTR[] pwszDNSName, ref uint pcchDNSName);
}
