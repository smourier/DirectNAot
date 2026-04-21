namespace DirectN;

[GeneratedComInterface, Guid("a4ed5c81-76c9-40bd-8be6-b1d90fb20ae7")]
public partial interface IAsyncActionCompletedHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Invoke([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAsyncAction>))] IAsyncAction asyncInfo, AsyncStatus asyncStatus);
}
