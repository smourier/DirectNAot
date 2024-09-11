#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/segment/nn-segment-imsvidtuner
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("1c15d47d-911d-11d2-b632-00c04f79498e")]
public partial interface IMSVidTuner : IMSVidVideoInputDevice
{
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidtuner-get_tune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Tune([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuneRequest>))] out ITuneRequest ppTR);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidtuner-put_tune
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Tune([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuneRequest>))] ITuneRequest pTR);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidtuner-get_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TuningSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpace>))] out ITuningSpace plTS);
    
    // https://learn.microsoft.com/windows/win32/api/segment/nf-segment-imsvidtuner-put_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TuningSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpace>))] ITuningSpace plTS);
}
