#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/regbag/nn-regbag-icreatepropbagonregkey
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8a674b48-1f63-11d3-b64c-00c04f79498e")]
public partial interface ICreatePropBagOnRegKey
{
    // https://learn.microsoft.com/windows/win32/api/regbag/nf-regbag-icreatepropbagonregkey-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(HKEY hkey, PWSTR subkey, uint ulOptions, uint samDesired, in Guid iid, out nint ppBag);
}
