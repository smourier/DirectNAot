#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-idvbtlocator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("8664da16-dda2-42ac-926a-c18f9127c302")]
public partial interface IDVBTLocator : IDigitalLocator
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Bandwidth(out int BandWidthVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_bandwidth
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Bandwidth(int BandwidthVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_lpinnerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LPInnerFEC(out FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_lpinnerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LPInnerFEC(FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_lpinnerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_LPInnerFECRate(out BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_lpinnerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_LPInnerFECRate(BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_halpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_HAlpha(out HierarchyAlpha Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_halpha
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_HAlpha(HierarchyAlpha Alpha);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_guard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Guard(out GuardInterval GI);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_guard
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Guard(GuardInterval GI);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Mode(out TransmissionMode mode);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_mode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Mode(TransmissionMode mode);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-get_otherfrequencyinuse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OtherFrequencyInUse(out VARIANT_BOOL OtherFrequencyInUseVal);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-idvbtlocator-put_otherfrequencyinuse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OtherFrequencyInUse(VARIANT_BOOL OtherFrequencyInUseVal);
}
