#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("c560298a-535c-48f9-866a-632540660cb4")]
public partial interface IPrintDocumentPackageTarget2
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetIsTargetIppPrinter([MarshalAs(UnmanagedType.U4)] out bool isIppPrinter);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTargetIppPrintDevice(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppvTarget);
}
