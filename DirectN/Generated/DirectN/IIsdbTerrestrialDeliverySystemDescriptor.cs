#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("39fae0a6-d151-44dd-a28a-765de5991670")]
public partial interface IIsdbTerrestrialDeliverySystemDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-getareacode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAreaCode(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-getguardinterval
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetGuardInterval(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-gettransmissionmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTransmissionMode(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbterrestrialdeliverysystemdescriptor-getrecordfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordFrequency(byte bRecordIndex, out uint pdwVal);
}
