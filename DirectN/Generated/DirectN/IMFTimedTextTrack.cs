#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtexttrack
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("8822c32d-654e-4233-bf21-d7f2e67d30d4")]
public partial interface IMFTimedTextTrack
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getid
    [PreserveSig]
    uint GetId();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLabel(out PWSTR label);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-setlabel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetLabel(PWSTR label);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getlanguage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLanguage(out PWSTR language);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-gettrackkind
    [PreserveSig]
    MF_TIMED_TEXT_TRACK_KIND GetTrackKind();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-isinband
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsInBand();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getinbandmetadatatrackdispatchtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInBandMetadataTrackDispatchType(out PWSTR dispatchType);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-isactive
    [PreserveSig]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvStdcall)])]
    BOOL IsActive();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-geterrorcode
    [PreserveSig]
    MF_TIMED_TEXT_ERROR_CODE GetErrorCode();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getextendederrorcode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetExtendedErrorCode();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtexttrack-getdataformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDataFormat(out Guid format);
    
    [PreserveSig]
    MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueList([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextCueList>))] out IMFTimedTextCueList cues);
}
