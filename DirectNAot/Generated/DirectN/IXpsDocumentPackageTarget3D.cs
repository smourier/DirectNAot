namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nn-xpsobjectmodel_2-ixpsdocumentpackagetarget3d
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("60ba71b8-3101-4984-9199-f4ea775ff01d")]
public partial interface IXpsDocumentPackageTarget3D
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nf-xpsobjectmodel_2-ixpsdocumentpackagetarget3d-getxpsompackagewriter3d
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsOMPackageWriter3D(IOpcPartUri documentSequencePartName, IOpcPartUri discardControlPartName, IOpcPartUri modelPartName, IStream modelData, out IXpsOMPackageWriter3D packageWriter);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nf-xpsobjectmodel_2-ixpsdocumentpackagetarget3d-getxpsomfactory
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsOMFactory(out IXpsOMObjectFactory xpsFactory);
}
