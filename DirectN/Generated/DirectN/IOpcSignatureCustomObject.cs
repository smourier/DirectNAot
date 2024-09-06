#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/msopc/nn-msopc-iopcsignaturecustomobject
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("5d77a19e-62c1-44e7-becd-45da5ae51a56")]
public partial interface IOpcSignatureCustomObject
{
    // https://learn.microsoft.com/windows/win32/api/msopc/nf-msopc-iopcsignaturecustomobject-getxml
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXml(out nint /* byte array */ xmlMarkup, out uint count);
}
