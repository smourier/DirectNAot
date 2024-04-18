namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1gdimetafilesink
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("82237326-8111-4f7c-bcf4-b5c1175564fe")]
public partial interface ID2D1GdiMetafileSink
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1gdimetafilesink-processrecord
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ProcessRecord(uint recordType, nint /* void */ recordData, uint recordDataSize);
}
