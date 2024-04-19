namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/sbe/nn-sbe-isbe2crossbar
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("547b6d26-3226-487e-8253-8aa168749434")]
public partial interface ISBE2Crossbar
{
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2crossbar-enabledefaultmode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnableDefaultMode(uint DefaultFlags);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2crossbar-getinitialprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInitialProfile(out ISBE2MediaTypeProfile ppProfile);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2crossbar-setoutputprofile
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOutputProfile(ISBE2MediaTypeProfile pProfile, out uint pcOutputPins, out IPin ppOutputPins);
    
    // https://learn.microsoft.com/windows/win32/api/sbe/nf-sbe-isbe2crossbar-enumstreams
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumStreams(out ISBE2EnumStream ppStreams);
}
