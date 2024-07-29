#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/documenttarget/nn-documenttarget-iprintdocumentpackagestatusevent
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af")]
public partial interface IPrintDocumentPackageStatusEvent : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/documenttarget/nf-documenttarget-iprintdocumentpackagestatusevent-packagestatusupdated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT PackageStatusUpdated(in PrintDocumentPackageStatus packageStatus);
}
