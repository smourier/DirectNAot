namespace DirectN;

[GeneratedComInterface, Guid("24230452-fe54-40cc-94f3-fcc394c340d6")]
public partial interface IMFMediaEngineTransferSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TransferSourceToMediaEngine(IMFMediaEngine destination);
}
