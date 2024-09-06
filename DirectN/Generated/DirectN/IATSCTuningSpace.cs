#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-iatsctuningspace
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("0369b4e2-45b6-11d3-b650-00c04f79498e")]
public partial interface IATSCTuningSpace : IAnalogTVTuningSpace
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-get_minminorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinMinorChannel(out int MinMinorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-put_minminorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinMinorChannel(int NewMinMinorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-get_maxminorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxMinorChannel(out int MaxMinorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-put_maxminorchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxMinorChannel(int NewMaxMinorChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-get_minphysicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MinPhysicalChannel(out int MinPhysicalChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-put_minphysicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MinPhysicalChannel(int NewMinPhysicalChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-get_maxphysicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_MaxPhysicalChannel(out int MaxPhysicalChannelVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-iatsctuningspace-put_maxphysicalchannel
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_MaxPhysicalChannel(int NewMaxPhysicalChannelVal);
}
