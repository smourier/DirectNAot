#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfpresentationclock
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("868ce85c-8ea9-4f55-ab82-b009a910a805")]
public partial interface IMFPresentationClock : IMFClock
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-settimesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetTimeSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationTimeSource>))] IMFPresentationTimeSource pTimeSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-gettimesource
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTimeSource([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFPresentationTimeSource>))] out IMFPresentationTimeSource ppTimeSource);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-gettime
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetTime(out long phnsClockTime);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-addclockstatesink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT AddClockStateSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFClockStateSink>))] IMFClockStateSink pStateSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-removeclockstatesink
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveClockStateSink([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFClockStateSink>))] IMFClockStateSink pStateSink);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-start
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Start(long llClockStartOffset);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Stop();
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfpresentationclock-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Pause();
}
