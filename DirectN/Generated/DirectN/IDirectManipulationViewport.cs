#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationviewport
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("28b85a3d-60a0-48bd-9ba1-5ce8d9ea3a6d")]
public partial interface IDirectManipulationViewport
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-enable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Enable();
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-disable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Disable();
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setcontact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetContact(uint pointerId);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-releasecontact
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseContact(uint pointerId);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-releaseallcontacts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseAllContacts();
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-getstatus
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStatus(out DIRECTMANIPULATION_STATUS status);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-gettag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTag(in Guid riid, out nint /* void */ @object, nint /* optional uint* */ id);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-settag
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTag(nint @object, uint id);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-getviewportrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetViewportRect(out RECT viewport);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setviewportrect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewportRect(in RECT viewport);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-zoomtorect
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ZoomToRect(float left, float top, float right, float bottom, BOOL animate);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setviewporttransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewportTransform([In][MarshalUsing(CountElementName = nameof(pointCount))] float[] matrix, uint pointCount);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-syncdisplaytransform
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SyncDisplayTransform([In][MarshalUsing(CountElementName = nameof(pointCount))] float[] matrix, uint pointCount);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-getprimarycontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrimaryContent(in Guid riid, out nint /* void */ @object);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-addcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddContent(IDirectManipulationContent content);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-removecontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveContent(IDirectManipulationContent content);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setviewportoptions
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-addconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-removeconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-activateconfiguration
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setmanualgesture
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setchaining
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-addeventhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddEventHandler(HWND window, IDirectManipulationViewportEventHandler eventHandler, out uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-removeeventhandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveEventHandler(uint cookie);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setinputmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-setupdatemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationviewport-abandon
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Abandon();
}
