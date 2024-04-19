namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ituningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("061c6e30-e622-11d2-9493-00c04f72d980")]
public partial interface ITuningSpace : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_uniquename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_UniqueName(out BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_uniquename
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_UniqueName(BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_friendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FriendlyName(out BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_friendlyname
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FriendlyName(BSTR Name);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_clsid
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CLSID(out BSTR SpaceCLSID);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_networktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_NetworkType(out BSTR NetworkTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_networktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_NetworkType(BSTR NetworkTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get__networktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get__NetworkType(out Guid NetworkTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put__networktype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put__NetworkType(in Guid NetworkTypeGuid);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-createtunerequest
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateTuneRequest(out ITuneRequest TuneRequest);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-enumcategoryguids
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumCategoryGUIDs(out IEnumGUID ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-enumdevicemonikers
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumDeviceMonikers(out IEnumMoniker ppEnum);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_defaultpreferredcomponenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultPreferredComponentTypes(out IComponentTypes ComponentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_defaultpreferredcomponenttypes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultPreferredComponentTypes(IComponentTypes NewComponentTypes);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_frequencymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_FrequencyMapping(out BSTR pMapping);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_frequencymapping
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_FrequencyMapping(BSTR Mapping);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-get_defaultlocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_DefaultLocator(out ILocator LocatorVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-put_defaultlocator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_DefaultLocator(ILocator LocatorVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ituningspace-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone(out ITuningSpace NewTS);
}
