#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_digitaldemodulator
[GeneratedComInterface, Guid("ef30f379-985b-4d10-b640-a79d5e04e1e0")]
public partial interface IBDA_DigitalDemodulator
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_modulationtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_ModulationType(in ModulationType pModulationType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_modulationtype
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_ModulationType(ref ModulationType pModulationType);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_innerfecmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InnerFECMethod(in FECMethod pFECMethod);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_innerfecmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InnerFECMethod(ref FECMethod pFECMethod);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_innerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_InnerFECRate(in BinaryConvolutionCodeRate pFECRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_innerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_InnerFECRate(ref BinaryConvolutionCodeRate pFECRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_outerfecmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OuterFECMethod(in FECMethod pFECMethod);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_outerfecmethod
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OuterFECMethod(ref FECMethod pFECMethod);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_outerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_OuterFECRate(in BinaryConvolutionCodeRate pFECRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_outerfecrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_OuterFECRate(ref BinaryConvolutionCodeRate pFECRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_symbolrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SymbolRate(in uint pSymbolRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_symbolrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SymbolRate(ref uint pSymbolRate);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-put_spectralinversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_SpectralInversion(in SpectralInversion pSpectralInversion);
    
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_digitaldemodulator-get_spectralinversion
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_SpectralInversion(ref SpectralInversion pSpectralInversion);
}
