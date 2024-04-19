namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-icodecapi
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("901db4c7-31ce-41a2-85dc-8fa0bf41b8da")]
public partial interface ICodecAPI
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-issupported
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsSupported(in Guid Api);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-ismodifiable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsModifiable(in Guid Api);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-getparameterrange
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameterRange(in Guid Api, out VARIANT ValueMin, out VARIANT ValueMax, out VARIANT SteppingDelta);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-getparametervalues
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetParameterValues(in Guid Api, out VARIANT Values, out uint ValuesCount);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-getdefaultvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDefaultValue(in Guid Api, out VARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-getvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetValue(in Guid Api, out VARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setvalue
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValue(in Guid Api, in VARIANT Value);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-registerforevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RegisterForEvent(in Guid Api, nint userData);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-unregisterforevent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT UnregisterForEvent(in Guid Api);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setalldefaults
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllDefaults();
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setvaluewithnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetValueWithNotify(in Guid Api, in VARIANT Value, out Guid ChangedParam, out uint ChangedParamCount);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setalldefaultswithnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllDefaultsWithNotify(out Guid ChangedParam, out uint ChangedParamCount);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-getallsettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAllSettings(IStream __MIDL__ICodecAPI0000);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setallsettings
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllSettings(IStream __MIDL__ICodecAPI0001);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-icodecapi-setallsettingswithnotify
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAllSettingsWithNotify(IStream __MIDL__ICodecAPI0002, out Guid ChangedParam, out uint ChangedParamCount);
}
