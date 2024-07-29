#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5c5cbd84-e755-11d0-ac18-00a0c9223196")]
public partial interface IKsClockPropertySet
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetTime(out long Time);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetTime(long Time);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetPhysicalTime(out long Time);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPhysicalTime(long Time);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetCorrelatedTime(out KSCORRELATED_TIME CorrelatedTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetCorrelatedTime(in KSCORRELATED_TIME CorrelatedTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetCorrelatedPhysicalTime(out KSCORRELATED_TIME CorrelatedTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetCorrelatedPhysicalTime(in KSCORRELATED_TIME CorrelatedTime);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetResolution(out KSRESOLUTION Resolution);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsGetState(out KSSTATE State);
}
