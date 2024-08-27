#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/textserv/nn-textserv-irichedituiaoverrides
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("f2fb5cc0-b5a9-437f-9ba2-47632082269f")]
public partial interface IRicheditUiaOverrides
{
    // https://learn.microsoft.com/windows/win32/api/textserv/nf-textserv-irichedituiaoverrides-getpropertyoverridevalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPropertyOverrideValue(int propertyId, ref VARIANT pRetValue);
}
