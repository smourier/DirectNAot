namespace DirectN;

[GeneratedComInterface, Guid("cd5ebe6b-8b6e-11d1-8ae0-00a0c9223196")]
public partial interface IKsPinFactory
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsPinFactory(out uint PinFactory);
}
