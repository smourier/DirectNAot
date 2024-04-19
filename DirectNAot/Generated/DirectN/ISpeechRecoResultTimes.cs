namespace DirectN;

[GeneratedComInterface, Guid("62b3b8fb-f6e7-41be-bdcb-056b1c29efc0")]
public partial interface ISpeechRecoResultTimes : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_StreamTime(out VARIANT Time);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Length(out VARIANT Length);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TickCount(out int TickCount);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OffsetFromStart(out VARIANT OffsetFromStart);
}
