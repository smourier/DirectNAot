#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/amaudio/nn-amaudio-iamdirectsound
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("546f4260-d53e-11cf-b3f0-00aa003761c5")]
public partial interface IAMDirectSound
{
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-getdirectsoundinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDirectSoundInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSound>))] out IDirectSound lplpds);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-getprimarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPrimaryBufferInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer>))] out IDirectSoundBuffer lplpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-getsecondarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSecondaryBufferInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer>))] out IDirectSoundBuffer lplpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-releasedirectsoundinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseDirectSoundInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSound>))] IDirectSound lpds);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-releaseprimarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleasePrimaryBufferInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer>))] IDirectSoundBuffer lpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-releasesecondarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseSecondaryBufferInterface([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDirectSoundBuffer>))] IDirectSoundBuffer lpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-setfocuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocusWindow(HWND param0, BOOL param1);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-getfocuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocusWindow(ref HWND param0, ref BOOL param1);
}
