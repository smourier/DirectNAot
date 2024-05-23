#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/documenttarget/nn-documenttarget-iprintdocumentpackagetargetfactory
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("d2959bf7-b31b-4a3d-9600-712eb1335ba4")]
public partial interface IPrintDocumentPackageTargetFactory
{
    // https://learn.microsoft.com/windows/win32/api/documenttarget/nf-documenttarget-iprintdocumentpackagetargetfactory-createdocumentpackagetargetforprintjob
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateDocumentPackageTargetForPrintJob(PWSTR printerName, PWSTR jobName, IStream jobOutputStream, IStream jobPrintTicketStream, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrintDocumentPackageTarget>))] out IPrintDocumentPackageTarget docPackageTarget);
}
