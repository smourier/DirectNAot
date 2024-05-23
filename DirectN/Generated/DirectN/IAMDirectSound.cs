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
    HRESULT ReleaseDirectSoundInterface(IDirectSound lpds);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-releaseprimarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleasePrimaryBufferInterface(IDirectSoundBuffer lpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-releasesecondarybufferinterface
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ReleaseSecondaryBufferInterface(IDirectSoundBuffer lpdsb);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-setfocuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetFocusWindow(HWND param0, [MarshalAs(UnmanagedType.U4)] bool param1);
    
    // https://learn.microsoft.com/windows/win32/api/amaudio/nf-amaudio-iamdirectsound-getfocuswindow
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFocusWindow(ref HWND param0, [MarshalAs(UnmanagedType.U4)] ref bool param1);
}
