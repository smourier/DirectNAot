namespace DirectN;

[GeneratedComInterface, Guid("4edb8ee2-96dd-49a7-94f7-4607ddab8e3c")]
public partial interface IGetActivationFactory : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActivationFactory(HSTRING activatableClassId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable factory);
}
