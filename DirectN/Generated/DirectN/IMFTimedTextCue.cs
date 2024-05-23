#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imftimedtextcue
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("1e560447-9a2b-43e1-a94c-b0aaabfbfbc9")]
public partial interface IMFTimedTextCue
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getid
    [PreserveSig]
    uint GetId();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getoriginalid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOriginalId(out PWSTR originalId);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getcuekind
    [PreserveSig]
    MF_TIMED_TEXT_TRACK_KIND GetCueKind();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getstarttime
    [PreserveSig]
    double GetStartTime();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getduration
    [PreserveSig]
    double GetDuration();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-gettrackid
    [PreserveSig]
    uint GetTrackId();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getdata
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetData([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextBinary>))] out IMFTimedTextBinary data);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getregion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRegion([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextRegion>))] out IMFTimedTextRegion region);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getstyle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStyle([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextStyle>))] out IMFTimedTextStyle style);
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getlinecount
    [PreserveSig]
    uint GetLineCount();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imftimedtextcue-getline
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLine(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextFormattedText>))] out IMFTimedTextFormattedText line);
}
