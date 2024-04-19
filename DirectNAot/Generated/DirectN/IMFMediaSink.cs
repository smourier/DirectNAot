namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasink
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("6ef2a660-47c0-4666-b13d-cbb717f2fa2c")]
public partial interface IMFMediaSink
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-getcharacteristics
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetCharacteristics(out uint pdwCharacteristics);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-addstreamsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddStreamSink(uint dwStreamSinkIdentifier, IMFMediaType pMediaType, out IMFStreamSink ppStreamSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-removestreamsink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveStreamSink(uint dwStreamSinkIdentifier);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-getstreamsinkcount
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSinkCount(out uint pcStreamSinkCount);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-getstreamsinkbyindex
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSinkByIndex(uint dwIndex, out IMFStreamSink ppStreamSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-getstreamsinkbyid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamSinkById(uint dwStreamSinkIdentifier, out IMFStreamSink ppStreamSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-setpresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPresentationClock(IMFPresentationClock pPresentationClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-getpresentationclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPresentationClock(out IMFPresentationClock ppPresentationClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasink-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
}
