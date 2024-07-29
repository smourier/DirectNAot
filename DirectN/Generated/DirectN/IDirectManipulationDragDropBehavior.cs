#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationdragdropbehavior
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("814b5af5-c2c8-4270-a9b7-a198ce8d02fa")]
public partial interface IDirectManipulationDragDropBehavior
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdragdropbehavior-setconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdragdropbehavior-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out DIRECTMANIPULATION_DRAG_DROP_STATUS status);
}
