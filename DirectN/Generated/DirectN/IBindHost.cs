#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("fc4801a1-2ba9-11cf-a229-00aa003d7352")]
public partial interface IBindHost
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateMoniker(PWSTR szName, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pBC, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] out IMoniker ppmk, uint dwReserved);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MonikerBindToStorage([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pMk, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pBC, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindStatusCallback>))] IBindStatusCallback pBSC, in Guid riid, out nint ppvObj);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT MonikerBindToObject([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMoniker>))] IMoniker pMk, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindCtx>))] IBindCtx pBC, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IBindStatusCallback>))] IBindStatusCallback pBSC, in Guid riid, out nint ppvObj);
}
