#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ieseventserviceconfiguration
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("33b9daae-9309-491d-a051-bcad2a70cd66")]
public partial interface IESEventServiceConfiguration
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-setparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetParent(IESEventService? pEventService);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-removeparent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveParent();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-setowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOwner(IESEvents? pESEvents);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-removeowner
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveOwner();
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-setgraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetGraph(IFilterGraph? pGraph);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ieseventserviceconfiguration-removegraph
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RemoveGraph(IFilterGraph? pGraph);
}
