namespace DirectN;

[GeneratedComInterface, Guid("1a9e9f4f-104f-4db8-a115-efd7fd0c97ae")]
public partial interface ISpeechCustomStream : ISpeechBaseStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_BaseStream(out nint ppUnkStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT putref_BaseStream(nint pUnkStream);
}
