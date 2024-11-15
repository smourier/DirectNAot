#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3d9f6448-7e95-4cb5-94fb-0180c2883a57")]
public partial interface IFixedPage : IPartBase
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrintTicket([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartPrintTicket>))] out IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPagePart(PWSTR uri, out nint ppUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetWriteStream([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPrintWriteStream>))] out IPrintWriteStream ppWriteStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPrintTicket([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IPartPrintTicket>))] IPartPrintTicket ppPrintTicket);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPagePart(nint pUnk);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DeleteResource(PWSTR uri);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetXpsPartIterator([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IXpsPartIterator>))] out IXpsPartIterator pXpsPartIt);
}
