#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidstreambuffersink3
[GeneratedComInterface, Guid("4f8721d7-7d59-4d8b-99f5-a77775586bd5")]
public partial interface IMSVidStreamBufferSink3 : IMSVidStreamBufferSink2
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-setminseek
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMinSeek(out int pdwMin);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_audiocounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_videocounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_cccounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CCCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_wstcounter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_WSTCounter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<nint>))] out nint ppUnk);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put_audioanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AudioAnalysisFilter(BSTR szCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_audioanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_AudioAnalysisFilter(out BSTR pszCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put__audioanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__AudioAnalysisFilter(Guid guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get__audioanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__AudioAnalysisFilter(out Guid pGuid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put_videoanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_VideoAnalysisFilter(BSTR szCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_videoanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VideoAnalysisFilter(out BSTR pszCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put__videoanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__VideoAnalysisFilter(Guid guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get__videoanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__VideoAnalysisFilter(out Guid pGuid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put_dataanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DataAnalysisFilter(BSTR szCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_dataanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DataAnalysisFilter(out BSTR pszCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-put__dataanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__DataAnalysisFilter(Guid guid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get__dataanalysisfilter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__DataAnalysisFilter(out Guid pGuid);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidstreambuffersink3-get_licenseerrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LicenseErrorCode(out HRESULT hres);
}
