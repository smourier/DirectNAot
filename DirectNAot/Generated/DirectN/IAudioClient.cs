namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/audioclient/nn-audioclient-iaudioclient
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("1cb9ad4c-dbfa-4c32-b178-c2f568a703b2")]
public partial interface IAudioClient
{
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-initialize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, uint StreamFlags, long hnsBufferDuration, long hnsPeriodicity, in WAVEFORMATEX pFormat, nint /* optional Guid */ AudioSessionGuid);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getbuffersize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBufferSize(out uint pNumBufferFrames);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getstreamlatency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamLatency(out long phnsLatency);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getcurrentpadding
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCurrentPadding(out uint pNumPaddingFrames);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-isformatsupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, in WAVEFORMATEX pFormat, nint /* optional WAVEFORMATEX */ ppClosestMatch);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getmixformat
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetMixFormat(out WAVEFORMATEX ppDeviceFormat);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getdeviceperiod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDevicePeriod(nint /* optional long */ phnsDefaultDevicePeriod, nint /* optional long */ phnsMinimumDevicePeriod);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start();
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-reset
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Reset();
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-seteventhandle
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetEventHandle(HANDLE eventHandle);
    
    // https://learn.microsoft.com/windows/win32/api/audioclient/nf-audioclient-iaudioclient-getservice
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetService(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
}
