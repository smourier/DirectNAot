#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfrelativepanelwatcher
[SupportedOSPlatform("windows10.0.19041")]
[GeneratedComInterface, Guid("421af7f6-573e-4ad0-8fda-2e57cedb18c6")]
public partial interface IMFRelativePanelWatcher : IMFShutdown
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrelativepanelwatcher-begingetreport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BeginGetReport(IMFAsyncCallback pCallback, nint pState);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrelativepanelwatcher-endgetreport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EndGetReport(IMFAsyncResult pResult, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFRelativePanelReport>))] out IMFRelativePanelReport ppRelativePanelReport);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfrelativepanelwatcher-getreport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetReport([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IMFRelativePanelReport>))] out IMFRelativePanelReport ppRelativePanelReport);
}
