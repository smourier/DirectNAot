#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nn-xpsobjectmodel_1-ixpsompackage1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("95a9435e-12bb-461b-8e7f-c6adb04cd96a")]
public partial interface IXpsOMPackage1 : IXpsOMPackage
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsompackage1-getdocumenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentType(out XPS_DOCUMENT_TYPE documentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsompackage1-writetofile1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteToFile1(PWSTR fileName, in SECURITY_ATTRIBUTES securityAttributes, uint flagsAndAttributes, BOOL optimizeMarkupSize, XPS_DOCUMENT_TYPE documentType);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsompackage1-writetostream1
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT WriteToStream1(ISequentialStream outputStream, BOOL optimizeMarkupSize, XPS_DOCUMENT_TYPE documentType);
}
