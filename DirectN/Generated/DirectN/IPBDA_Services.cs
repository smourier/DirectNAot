#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-ipbda_services
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("944eab37-eed4-4850-afd2-77e7efeb4427")]
public partial interface IPBDA_Services
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbda_services-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(uint size, nint /* byte array */ pBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbda_services-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-ipbda_services-getrecordbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordByIndex(uint dwRecordIndex, out ulong pul64ServiceIdx);
}
