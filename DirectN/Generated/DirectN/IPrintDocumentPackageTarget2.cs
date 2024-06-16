#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c560298a-535c-48f9-866a-632540660cb4")]
public partial interface IPrintDocumentPackageTarget2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsTargetIppPrinter(out BOOL isIppPrinter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetIppPrintDevice(in Guid riid, out nint /* void */ ppvTarget);
}
