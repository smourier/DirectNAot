#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nn-textserv-irichedituiaoverrides
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("00000000-0000-0000-0000-000000000000")]
public partial interface IRicheditUiaOverrides
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-irichedituiaoverrides-getpropertyoverridevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyOverrideValue(int propertyId, ref VARIANT pRetValue);
}
