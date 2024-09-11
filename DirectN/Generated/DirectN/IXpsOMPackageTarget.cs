#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nn-xpsobjectmodel-ixpsompackagetarget
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("219a9db0-4959-47d0-8034-b1ce84f41a4d")]
public partial interface IXpsOMPackageTarget
{
    // https://learn.microsoft.com/windows/win32/api/xpsobjectmodel/nf-xpsobjectmodel-ixpsompackagetarget-createxpsompackagewriter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateXpsOMPackageWriter([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri documentSequencePartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPrintTicketResource>))] IXpsOMPrintTicketResource documentSequencePrintTicket, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IOpcPartUri>))] IOpcPartUri discardControlPartName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsOMPackageWriter>))] out IXpsOMPackageWriter packageWriter);
}
