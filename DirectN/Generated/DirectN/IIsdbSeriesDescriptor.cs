#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dvbsiparser/nn-dvbsiparser-iisdbseriesdescriptor
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("07ef6370-1660-4f26-87fc-614adab24b11")]
public partial interface IIsdbSeriesDescriptor
{
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getlength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLength(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getseriesid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSeriesId(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getrepeatlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRepeatLabel(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getprogrampattern
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProgramPattern(nint /* byte array */ pbVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getexpiredate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExpireDate([MarshalAs(UnmanagedType.U4)] out bool pfValid, out MPEG_DATE_AND_TIME pmdtVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getepisodenumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEpisodeNumber(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getlastepisodenumber
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLastEpisodeNumber(out ushort pwVal);
    
    // https://learn.microsoft.com/windows/win32/api/dvbsiparser/nf-dvbsiparser-iisdbseriesdescriptor-getseriesnamew
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSeriesNameW(DVB_STRCONV_MODE convMode, out BSTR pbstrName);
}
