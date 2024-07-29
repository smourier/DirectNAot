#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("2c9db356-e70d-4642-8298-bc4aa5b4865c")]
public partial interface ICompositionCapabilitiesInteropFactory : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForWindow(HWND hwnd, out nint /* object */ result);
}
