#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8be47b07-57f6-11d2-9eee-00c04f797396")]
public partial interface ISpeechVoiceStatus : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CurrentStreamNumber(out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastStreamNumberQueued(out int StreamNumber);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastHResult(out int HResult);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_RunningState(out SpeechRunState State);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputWordPosition(out int Position);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputWordLength(out int Length);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputSentencePosition(out int Position);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InputSentenceLength(out int Length);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastBookmark(out BSTR Bookmark);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LastBookmarkId(out int BookmarkId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PhonemeId(out short PhoneId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_VisemeId(out short VisemeId);
}
