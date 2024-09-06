#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("ad128745-211b-40a0-9981-fe65f166d0fd")]
public partial interface IMFTimedTextCueList
{
    [PreserveSig]
    uint GetLength();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueByIndex(uint index, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextCue>))] out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueById(uint id, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextCue>))] out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCueByOriginalId(PWSTR originalId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTimedTextCue>))] out IMFTimedTextCue cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddTextCue(double start, double duration, PWSTR text, nint /* optional IMFTimedTextCue* */ cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddDataCue(double start, double duration, nint /* byte array */ data, uint dataSize, nint /* optional IMFTimedTextCue* */ cue);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveCue(IMFTimedTextCue cue);
}
