#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dmusics/nn-dmusics-idirectmusicsynthsink
[GeneratedComInterface, Guid("09823663-5c85-11d2-afa6-00aa0024d8b6")]
public partial interface IDirectMusicSynthSink
{
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-init
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Init(IDirectMusicSynth pSynth);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-setmasterclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetMasterClock(IReferenceClock pClock);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-getlatencyclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetLatencyClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceClock>))] out IReferenceClock ppClock);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Activate([MarshalAs(UnmanagedType.U4)] bool fEnable);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-sampletoreftime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SampleToRefTime(long llSampleTime, ref long prfTime);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-reftimetosample
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RefTimeToSample(long rfTime, ref long pllSampleTime);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-setdirectsound
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDirectSound(IDirectSound pDirectSound, IDirectSoundBuffer pDirectSoundBuffer);
    
    // https://learn.microsoft.com/windows/win32/api/dmusics/nf-dmusics-idirectmusicsynthsink-getdesiredbuffersize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDesiredBufferSize(ref uint pdwBufferSizeInSamples);
}
