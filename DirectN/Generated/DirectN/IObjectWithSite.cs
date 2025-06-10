#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iobjectwithsite
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("fc4801a3-2ba9-11cf-a229-00aa003d7352")]
public partial interface IObjectWithSite
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iobjectwithsite-setsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSite(nint pUnkSite);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iobjectwithsite-getsite
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSite(in Guid riid, out nint /* void */ ppvSite);
}
