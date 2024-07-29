#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfnetschemehandlerconfig
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7be19e73-c9bf-468a-ac5a-a5e8653bec87")]
public partial interface IMFNetSchemeHandlerConfig
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetschemehandlerconfig-getnumberofsupportedprotocols
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfSupportedProtocols(out uint pcProtocols);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetschemehandlerconfig-getsupportedprotocoltype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSupportedProtocolType(uint nProtocolIndex, out MFNETSOURCE_PROTOCOL_TYPE pnProtocolType);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfnetschemehandlerconfig-resetprotocolrolloversettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetProtocolRolloverSettings();
}
