namespace DirectN;

[GeneratedComInterface, Guid("c5bc37d6-75c7-46a1-a132-81b5f723c20f")]
public partial interface IMFMediaStream2 : IMFMediaStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamState(MF_STREAM_STATE value);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamState(out MF_STREAM_STATE value);
}
