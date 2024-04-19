namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmdrmwriter3
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a7184082-a4aa-4dde-ac9c-e75dbd1117ce")]
public partial interface IWMDRMWriter3 : IWMDRMWriter2
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmdrmwriter3-setprotectstreamsamples
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProtectStreamSamples(in WMDRM_IMPORT_INIT_STRUCT pImportInitStruct);
}
