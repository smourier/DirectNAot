namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/control/nn-control-ibasicaudio
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("56a868b3-0ad4-11ce-b03a-0020af0ba770")]
public partial interface IBasicAudio : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicaudio-put_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Volume(int lVolume);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicaudio-get_volume
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Volume(out int plVolume);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicaudio-put_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Balance(int lBalance);
    
    // https://learn.microsoft.com/windows/win32/api/control/nf-control-ibasicaudio-get_balance
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Balance(out int plBalance);
}
