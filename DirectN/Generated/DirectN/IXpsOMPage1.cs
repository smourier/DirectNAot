#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nn-xpsobjectmodel_1-ixpsompage1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("305b60ef-6892-4dda-9cbb-3aa65974508a")]
public partial interface IXpsOMPage1 : IXpsOMPage
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsompage1-getdocumenttype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDocumentType(out XPS_DOCUMENT_TYPE documentType);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Write1(ISequentialStream stream, BOOL optimizeMarkupSize, XPS_DOCUMENT_TYPE documentType);
}
