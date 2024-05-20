#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objidl/nn-objidl-iapartmentshutdown
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("a2f05a09-27a2-42b5-bc0e-ac163ef49d9b")]
public partial interface IApartmentShutdown
{
    // https://learn.microsoft.com/windows/win32/api/objidl/nf-objidl-iapartmentshutdown-onuninitialize
    [PreserveSig]
    void OnUninitialize(ulong ui64ApartmentIdentifier);
}
