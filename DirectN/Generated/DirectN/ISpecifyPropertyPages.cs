#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-ispecifypropertypages
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b28b-bab4-101a-b69c-00aa00341d07")]
public partial interface ISpecifyPropertyPages
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-ispecifypropertypages-getpages
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPages(out CAUUID pPages);
}
