#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3b0d0ea4-d0a9-4b0e-935b-09516746fac0")]
public partial interface IMMDeviceActivator
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate(in Guid iid, IMMDevice pDevice, nint /* optional PROPVARIANT* */ pActivationParams, out nint ppInterface);
}
