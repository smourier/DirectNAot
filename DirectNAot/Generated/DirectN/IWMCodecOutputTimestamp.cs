#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nn-wmcodecdsp-iwmcodecoutputtimestamp
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("b72adf95-7adc-4a72-bc05-577d8ea6bf68")]
public partial interface IWMCodecOutputTimestamp
{
    // https://learn.microsoft.com/windows/win32/api/wmcodecdsp/nf-wmcodecdsp-iwmcodecoutputtimestamp-getnextoutputtime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNextOutputTime(ref long prtTime);
}
