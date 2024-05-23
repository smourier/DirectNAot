#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/activation/nn-activation-iactivationfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("00000035-0000-0000-c000-000000000046")]
public partial interface IActivationFactory : IInspectable
{
    // https://learn.microsoft.com/windows/win32/api/activation/nf-activation-iactivationfactory-activateinstance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateInstance([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IInspectable>))] out IInspectable instance);
}
