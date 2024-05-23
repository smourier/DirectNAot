#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("6450336f-7d49-4ced-8097-49d6dee37294")]
public partial interface ISpeechBaseStream : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Format([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpeechAudioFormat>))] out ISpeechAudioFormat AudioFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_Format(ISpeechAudioFormat? AudioFormat);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Read(out VARIANT Buffer, int NumberOfBytes, out int BytesRead);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write(VARIANT Buffer, out int BytesWritten);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, out VARIANT NewPosition);
}
