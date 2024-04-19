namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcodecprivatedata
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("73f0be8e-57f7-4f01-aa66-9f57340cfe0e")]
public partial interface IWMCodecPrivateData
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecprivatedata-setpartialoutputtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPartialOutputType(ref DMO_MEDIA_TYPE pmt);
    
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecprivatedata-getprivatedata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrivateData(nint /* byte array */ pbData, ref uint pcbData);
}
