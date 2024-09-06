#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfmediasession
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("90377834-21d0-4dee-8214-ba2e3e6c1127")]
public partial interface IMFMediaSession : IMFMediaEventGenerator
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-settopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTopology(uint dwSetTopologyFlags, IMFTopology pTopology);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-cleartopologies
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ClearTopologies();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(in Guid pguidTimeFormat, in PROPVARIANT pvarStartPosition);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-close
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-shutdown
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Shutdown();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-getclock
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetClock([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFClock>))] out IMFClock ppClock);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-getsessioncapabilities
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSessionCapabilities(out uint pdwCaps);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfmediasession-getfulltopology
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFullTopology(uint dwGetFullTopologyFlags, ulong TopoId, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFTopology>))] out IMFTopology ppFullTopology);
}
