namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmstreamconfig2
[GeneratedComInterface, Guid("7688d8cb-fc0d-43bd-9459-5a8dec200cfa")]
public partial interface IWMStreamConfig2 : IWMStreamConfig
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-gettransporttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransportType(out WMT_TRANSPORT_TYPE pnTransportType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-settransporttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTransportType(WMT_TRANSPORT_TYPE nTransportType);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-adddataunitextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataUnitExtension(Guid guidExtensionSystemID, ushort cbExtensionDataSize, nint /* byte array */ pbExtensionSystemInfo, uint cbExtensionSystemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-getdataunitextensioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataUnitExtensionCount(out ushort pcDataUnitExtensions);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-getdataunitextension
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataUnitExtension(ushort wDataUnitExtensionNumber, out Guid pguidExtensionSystemID, out ushort pcbExtensionDataSize, nint /* byte array */ pbExtensionSystemInfo, ref uint pcbExtensionSystemInfo);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmstreamconfig2-removealldataunitextensions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveAllDataUnitExtensions();
}
