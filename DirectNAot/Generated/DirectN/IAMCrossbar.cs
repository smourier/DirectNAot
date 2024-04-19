namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/nn-strmif-iamcrossbar
[SupportedOSPlatform("windows5.0")]
[GeneratedComInterface, Guid("c6e13380-30ac-11d0-a18c-00a0c9118956")]
public partial interface IAMCrossbar
{
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcrossbar-get_pincounts
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_PinCounts(out int OutputPinCount, out int InputPinCount);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcrossbar-canroute
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CanRoute(int OutputPinIndex, int InputPinIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcrossbar-route
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Route(int OutputPinIndex, int InputPinIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcrossbar-get_isroutedto
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_IsRoutedTo(int OutputPinIndex, out int InputPinIndex);
    
    // https://learn.microsoft.com/windows/win32/api/strmif/nf-strmif-iamcrossbar-get_crossbarpininfo
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CrossbarPinInfo([MarshalAs(UnmanagedType.U4)] bool IsInputPin, int PinIndex, out int PinIndexRelated, out int PhysicalType);
}
