#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ocidl/nn-ocidl-iclassfactory2
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("b196b28f-bab4-101a-b69c-00aa00341d07")]
public partial interface IClassFactory2 : IClassFactory
{
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iclassfactory2-getlicinfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLicInfo(ref LICINFO pLicInfo);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iclassfactory2-requestlickey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RequestLicKey(uint dwReserved, out BSTR pBstrKey);
    
    // https://learn.microsoft.com/windows/win32/api/ocidl/nf-ocidl-iclassfactory2-createinstancelic
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInstanceLic(nint pUnkOuter, nint pUnkReserved, in Guid riid, BSTR bstrKey, out nint /* void */ ppvObj);
}
