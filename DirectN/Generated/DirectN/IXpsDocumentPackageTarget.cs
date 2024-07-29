#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nn-xpsobjectmodel_1-ixpsdocumentpackagetarget
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("3b0b6d38-53ad-41da-b212-d37637a6714e")]
public partial interface IXpsDocumentPackageTarget
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsdocumentpackagetarget-getxpsompackagewriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsOMPackageWriter(IOpcPartUri documentSequencePartName, IOpcPartUri discardControlPartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsdocumentpackagetarget-getxpsomfactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsOMFactory([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMObjectFactory>))] out IXpsOMObjectFactory xpsFactory);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_1/nf-xpsobjectmodel_1-ixpsdocumentpackagetarget-getxpstype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsType(out XPS_DOCUMENT_TYPE documentType);
}
