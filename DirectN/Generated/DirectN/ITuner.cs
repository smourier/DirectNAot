#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ituner
[GeneratedComInterface, Guid("28c52640-018a-11d3-9d8e-00c04f72d980")]
public partial interface ITuner
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-get_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TuningSpace([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuningSpace>))] out ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-put_tuningspace
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TuningSpace(ITuningSpace TuningSpace);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-enumtuningspaces
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumTuningSpaces([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IEnumTuningSpaces>))] out IEnumTuningSpaces ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-get_tunerequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_TuneRequest([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ITuneRequest>))] out ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-put_tunerequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_TuneRequest(ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-validate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Validate(ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-get_preferredcomponenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PreferredComponentTypes([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IComponentTypes>))] out IComponentTypes ComponentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-put_preferredcomponenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_PreferredComponentTypes(IComponentTypes ComponentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-get_signalstrength
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SignalStrength(out int Strength);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituner-triggersignalevents
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TriggerSignalEvents(int Interval);
}
