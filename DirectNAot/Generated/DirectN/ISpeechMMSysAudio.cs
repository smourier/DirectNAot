namespace DirectN;

[GeneratedComInterface, Guid("3c76af6d-1fd7-4831-81d1-3b71d5a13c44")]
public partial interface ISpeechMMSysAudio : ISpeechAudio
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DeviceId(out int DeviceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DeviceId(int DeviceId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LineId(out int LineId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LineId(int LineId);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MMHandle(out int Handle);
}
