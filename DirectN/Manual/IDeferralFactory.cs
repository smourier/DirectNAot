namespace DirectN;

[GeneratedComInterface, Guid("65a1ecc5-3fb5-4832-8ca9-f061b281d13a")]
public partial interface IDeferralFactory : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDeferralCompletedHandler>))] IDeferralCompletedHandler handler, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDeferral>))] out IDeferral deferral);
}
