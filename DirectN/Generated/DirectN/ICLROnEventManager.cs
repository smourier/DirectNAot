#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("1d0e0132-e64f-493d-9260-025c0e32c175")]
public partial interface ICLROnEventManager
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterActionOnEvent(EClrEvent @event, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActionOnCLREvent>))] IActionOnCLREvent pAction);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterActionOnEvent(EClrEvent @event, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IActionOnCLREvent>))] IActionOnCLREvent pAction);
}
