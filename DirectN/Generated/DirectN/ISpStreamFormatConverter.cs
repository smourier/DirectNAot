#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("678a932c-ea71-4446-9b41-78fda6280a29")]
public partial interface ISpStreamFormatConverter : ISpStreamFormat
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBaseStream(ISpStreamFormat? pStream, [MarshalAs(UnmanagedType.U4)] bool fSetFormatToBaseStreamFormat, [MarshalAs(UnmanagedType.U4)] bool fWriteToBaseStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBaseStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpStreamFormat>))] out ISpStreamFormat ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFormat(in Guid rguidFormatIdOfConvertedStream, in WAVEFORMATEX pWaveFormatExOfConvertedStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ResetSeekPosition();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScaleConvertedToBaseOffset(ulong ullOffsetConvertedStream, out ulong pullOffsetBaseStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ScaleBaseToConvertedOffset(ulong ullOffsetBaseStream, out ulong pullOffsetConvertedStream);
}
