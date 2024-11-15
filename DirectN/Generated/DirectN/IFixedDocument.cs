#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("f222ca9f-9968-4db9-81bd-abaebf15f93f")]
public partial interface IFixedDocument
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
