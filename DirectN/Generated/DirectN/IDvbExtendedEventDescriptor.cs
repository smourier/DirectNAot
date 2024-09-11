#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-idvbextendedeventdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("c9b22eca-85f4-499f-b1db-efa93a91ee57")]
public partial interface IDvbExtendedEventDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getdescriptornumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDescriptorNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getlastdescriptornumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastDescriptorNumber(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getlanguagecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguageCode(nint /* byte array */ pszCode);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getrecorditemw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordItemW(byte bRecordIndex, DVB_STRCONV_MODE convMode, out BSTR pbstrDesc, out BSTR pbstrItem);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getconcatenateditemw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConcatenatedItemW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvbExtendedEventDescriptor>))] IDvbExtendedEventDescriptor pFollowingDescriptor, DVB_STRCONV_MODE convMode, out BSTR pbstrDesc, out BSTR pbstrItem);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-gettextw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextW(DVB_STRCONV_MODE convMode, out BSTR pbstrText);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getconcatenatedtextw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetConcatenatedTextW([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDvbExtendedEventDescriptor>))] IDvbExtendedEventDescriptor FollowingDescriptor, DVB_STRCONV_MODE convMode, out BSTR pbstrText);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-idvbextendedeventdescriptor-getrecorditemrawbytes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordItemRawBytes(byte bRecordIndex, out nint /* byte array */ ppbRawItem, nint /* byte array */ pbItemLength);
}
