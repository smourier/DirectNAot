#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
[GeneratedComInterface, Guid("0c0e4080-9081-11d2-beec-0060082f2054")]
public partial interface INSNetSourceCreator
{
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nf-wmnetsourcecreator-insnetsourcecreator-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize();
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateNetSource(PWSTR pszStreamName, nint pMonitor, nint /* byte array */ pData, nint pUserContext, nint pCallback, ulong qwContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceProperties(PWSTR pszStreamName, out nint ppPropertiesNode);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceSharedNamespace(out nint ppSharedNamespace);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nf-wmnetsourcecreator-insnetsourcecreator-getnetsourceadmininterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNetSourceAdminInterface(PWSTR pszStreamName, out VARIANT pVal);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumProtocolsSupported(out uint pcProtocols);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nn-wmnetsourcecreator-insnetsourcecreator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolName(uint dwProtocolNum, out PWSTR pwszProtocolName, ref ushort pcchProtocolName);
    
    // https://learn.microsoft.com/windows/win32/api/wmnetsourcecreator/nf-wmnetsourcecreator-insnetsourcecreator-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
