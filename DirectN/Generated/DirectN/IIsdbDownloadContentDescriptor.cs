#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbdownloadcontentdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5298661e-cb88-4f5f-a1de-5f440c185b92")]
public partial interface IIsdbDownloadContentDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getflags
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFlags([MarshalAs(UnmanagedType.U4)] out bool pfReboot, [MarshalAs(UnmanagedType.U4)] out bool pfAddOn, [MarshalAs(UnmanagedType.U4)] out bool pfCompatibility, [MarshalAs(UnmanagedType.U4)] out bool pfModuleInfo, [MarshalAs(UnmanagedType.U4)] out bool pfTextInfo);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getcomponentsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentSize(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getdownloadid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDownloadId(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-gettimeoutvaluedii
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeOutValueDII(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getleakrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLeakRate(out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getcomponenttag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetComponentTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getcompatiblitydescriptorlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompatiblityDescriptorLength(out ushort pwLength);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getcompatiblitydescriptor
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCompatiblityDescriptor(out nint /* byte array */ ppbData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getcountofrecords
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCountOfRecords(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getrecordmoduleid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordModuleId(ushort wRecordIndex, out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getrecordmodulesize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordModuleSize(ushort wRecordIndex, out uint pdwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getrecordmoduleinfolength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordModuleInfoLength(ushort wRecordIndex, nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-getrecordmoduleinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRecordModuleInfo(ushort wRecordIndex, out nint /* byte array */ ppbData);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-gettextlanguagecode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextLanguageCode(nint /* byte array */ szCode);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbdownloadcontentdescriptor-gettextw
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTextW(DVB_STRCONV_MODE convMode, out BSTR pbstrName);
}
