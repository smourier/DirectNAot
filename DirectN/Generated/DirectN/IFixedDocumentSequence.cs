#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("8028d181-2c32-4249-8493-1bfb22045574")]
public partial interface IFixedDocumentSequence
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetUri(out BSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrintTicket([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartPrintTicket>))] out IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrintTicket([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartPrintTicket>))] IPartPrintTicket pPrintTicket);
}
