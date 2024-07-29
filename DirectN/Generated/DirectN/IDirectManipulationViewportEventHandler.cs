#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationviewporteventhandler
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("952121da-d69f-45f9-b0f9-f23944321a6d")]
public partial interface IDirectManipulationViewportEventHandler
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewporteventhandler-onviewportstatuschanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnViewportStatusChanged(IDirectManipulationViewport viewport, DIRECTMANIPULATION_STATUS current, DIRECTMANIPULATION_STATUS previous);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewporteventhandler-onviewportupdated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnViewportUpdated(IDirectManipulationViewport viewport);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewporteventhandler-oncontentupdated
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnContentUpdated(IDirectManipulationViewport viewport, IDirectManipulationContent content);
}
