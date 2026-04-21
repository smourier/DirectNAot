namespace DirectN;

[GeneratedComInterface, Guid("5a648006-843a-4da9-865b-9d26e5dfad7b")]
public partial interface IAsyncAction : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Completed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAsyncActionCompletedHandler>))] IAsyncActionCompletedHandler handler);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Completed([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAsyncActionCompletedHandler>))] out IAsyncActionCompletedHandler handler);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetResults();
}
