namespace DirectN;

[GeneratedComInterface, Guid("143c8dcb-d37f-47f7-88e8-6b1d21f2c5f7")]
public partial interface IPrintSchemaAsyncOperation : IDispatch
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Start();
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Cancel();
}
