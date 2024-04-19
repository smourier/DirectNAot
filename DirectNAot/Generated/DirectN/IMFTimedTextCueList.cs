namespace DirectN;

[GeneratedComInterface, Guid("ad128745-211b-40a0-9981-fe65f166d0fd")]
public partial interface IMFTimedTextCueList
{
    [PreserveSig]
    uint GetLength();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueByIndex(uint index, out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueById(uint id, out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueByOriginalId(PWSTR originalId, out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTextCue(double start, double duration, PWSTR text, nint/* nint */ cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataCue(double start, double duration, nint /* byte array */ data, uint dataSize, nint/* nint */ cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveCue(IMFTimedTextCue cue);
}
