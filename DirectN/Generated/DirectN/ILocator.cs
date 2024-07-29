#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/tuner/nn-tuner-ilocator
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("286d7f89-760c-4f89-80c4-66841d2507aa")]
public partial interface ILocator : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_carrierfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_CarrierFrequency(out int Frequency);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_carrierfrequency
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_CarrierFrequency(int Frequency);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_innerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InnerFEC(out FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_innerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InnerFEC(FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_innerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InnerFECRate(out BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_innerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InnerFECRate(BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_outerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OuterFEC(out FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_outerfec
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OuterFEC(FECMethod FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_outerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OuterFECRate(out BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_outerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OuterFECRate(BinaryConvolutionCodeRate FEC);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_modulation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Modulation(out ModulationType Modulation);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_modulation
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_Modulation(ModulationType Modulation);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-get_symbolrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SymbolRate(out int Rate);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-put_symbolrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SymbolRate(int Rate);
    
    // https://learn.microsoft.com/windows/win32/api/tuner/nf-tuner-ilocator-clone
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Clone([MarshalUsing(typeof(UniqueComInterfaceMarshaller<ILocator>))] out ILocator NewLocator);
}
