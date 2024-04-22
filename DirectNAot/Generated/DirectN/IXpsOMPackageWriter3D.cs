namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nn-xpsobjectmodel_2-ixpsompackagewriter3d
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("e8a45033-640e-43fa-9bdf-fddeaa31c6a0")]
public partial interface IXpsOMPackageWriter3D : IXpsOMPackageWriter
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nf-xpsobjectmodel_2-ixpsompackagewriter3d-addmodeltexture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddModelTexture(IOpcPartUri texturePartName, IStream textureData);
    
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel_2/nf-xpsobjectmodel_2-ixpsompackagewriter3d-setmodelprintticket
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetModelPrintTicket(IOpcPartUri printTicketPartName, IStream printTicketData);
}
