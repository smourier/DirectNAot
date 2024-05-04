#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfsignedlibrary
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("4a724bca-ff6a-4c07-8e0d-7a358421cf06")]
public partial interface IMFSignedLibrary
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfsignedlibrary-getprocedureaddress
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProcedureAddress(PSTR name, out nint address);
}
