#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/nn-wmsdkidl-iwmreaderadvanced2
[GeneratedComInterface, Guid("ae14a945-b90c-4d0d-9127-80d665f7d73e")]
public partial interface IWMReaderAdvanced2 : IWMReaderAdvanced
{
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-setplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPlayMode(WMT_PLAY_MODE Mode);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getplaymode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPlayMode(out WMT_PLAY_MODE pMode);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getbufferprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferProgress(out uint pdwPercent, out ulong pcnsBuffering);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getdownloadprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDownloadProgress(out uint pdwPercent, out ulong pqwBytesDownloaded, out ulong pcnsDownload);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getsaveasprogress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSaveAsProgress(out uint pdwPercent);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-savefileas
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SaveFileAs(PWSTR pwszFilename);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getprotocolname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProtocolName([MarshalUsing(CountElementName = nameof(pcchProtocol))] PWSTR pwszProtocol, ref uint pcchProtocol);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-startatmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StartAtMarker(ushort wMarkerIndex, ulong cnsDuration, float fRate, nint pvContext);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getoutputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputSetting(uint dwOutputNum, PWSTR pszName, out WMT_ATTR_DATATYPE pType, nint /* byte array */ pValue, ref ushort pcbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-setoutputsetting
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputSetting(uint dwOutputNum, PWSTR pszName, WMT_ATTR_DATATYPE Type, nint /* byte array */ pValue, ushort cbLength);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-preroll
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Preroll(ulong cnsStart, ulong cnsDuration, float fRate);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-setlogclientid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLogClientID(BOOL fLogClientID);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-getlogclientid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLogClientID(out BOOL pfLogClientID);
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-stopbuffering
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT StopBuffering();
    
    // https://learn.microsoft.com/windows/win32/api/wmsdkidl/nf-wmsdkidl-iwmreaderadvanced2-openstream
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OpenStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IStream>))] IStream pStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMReaderCallback>))] IWMReaderCallback pCallback, nint pvContext);
}
