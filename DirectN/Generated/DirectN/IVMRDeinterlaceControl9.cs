#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrdeinterlacecontrol9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("a215fb8d-13c2-4f7f-993c-003d6271a459")]
public partial interface IVMRDeinterlaceControl9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-getnumberofdeinterlacemodes
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetNumberOfDeinterlaceModes(in VMR9VideoDesc lpVideoDescription, ref uint lpdwNumDeinterlaceModes, out Guid lpDeinterlaceModes);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-getdeinterlacemodecaps
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlaceModeCaps(in Guid lpDeinterlaceMode, in VMR9VideoDesc lpVideoDescription, out VMR9DeinterlaceCaps lpDeinterlaceCaps);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-getdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlaceMode(uint dwStreamID, out Guid lpDeinterlaceMode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-setdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeinterlaceMode(uint dwStreamID, in Guid lpDeinterlaceMode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-getdeinterlaceprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetDeinterlacePrefs(out uint lpdwDeinterlacePrefs);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-setdeinterlaceprefs
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetDeinterlacePrefs(uint dwDeinterlacePrefs);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrdeinterlacecontrol9-getactualdeinterlacemode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetActualDeinterlaceMode(uint dwStreamID, out Guid lpDeinterlaceMode);
}
