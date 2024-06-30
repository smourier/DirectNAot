#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/atscpsipparser/nn-atscpsipparser-iscte_eas
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1ff544d6-161d-4fae-9faa-4f9f492ae999")]
public partial interface ISCTE_EAS
{
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ISectionList? pSectionList, IMpeg2Data? pMPEGData);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getversionnumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetVersionNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getsequencynumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSequencyNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getprotocolversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolVersion(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-geteaseventid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEASEventID(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getoriginatorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginatorCode(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-geteaseventcodelen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEASEventCodeLen(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-geteaseventcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEASEventCode(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getrawnatureofactivationtextlen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawNatureOfActivationTextLen(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getrawnatureofactivationtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawNatureOfActivationText(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getnatureofactivationtext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNatureOfActivationText(BSTR bstrIS0639code, out BSTR pbstrString);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-gettimeremaining
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeRemaining(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getstarttime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStartTime(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getduration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDuration(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getalertpriority
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlertPriority(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getdetailsoobsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsOOBSourceID(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getdetailsmajor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsMajor(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getdetailsminor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsMinor(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getdetailsaudiooobsourceid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDetailsAudioOOBSourceID(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getalerttext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAlertText(BSTR bstrIS0639code, out BSTR pbstrString);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getrawalerttextlen
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawAlertTextLen(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getrawalerttext
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRawAlertText(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getlocationcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocationCount(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getlocationcodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLocationCodes(byte bIndex, nint /* byte array */ pbState, nint /* byte array */ pbCountySubdivision, out ushort pwCounty);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getexceptioncount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExceptionCount(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getexceptionservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExceptionService(byte bIndex, nint /* byte array */ pbIBRef, out ushort pwFirst, out ushort pwSecond);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-getcountoftabledescriptors
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfTableDescriptors(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-gettabledescriptorbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByIndex(uint dwIndex, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
    
    // https://learn.microsoft.com/windows/win32/api/atscpsipparser/nf-atscpsipparser-iscte_eas-gettabledescriptorbytag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTableDescriptorByTag(byte bTag, ref uint pdwCookie, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IGenericDescriptor>))] out IGenericDescriptor ppDescriptor);
}
