namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationdragdropeventhandler
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("1fa11b10-701b-41ae-b5f2-49e36bd595aa")]
public partial interface IDirectManipulationDragDropEventHandler
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationdragdropeventhandler-ondragdropstatuschange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnDragDropStatusChange(IDirectManipulationViewport2 viewport, DIRECTMANIPULATION_DRAG_DROP_STATUS current, DIRECTMANIPULATION_DRAG_DROP_STATUS previous);
}
