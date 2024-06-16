#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmrvideostreamcontrol9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("d0cfe38b-93e7-4772-8957-0400c49a4485")]
public partial interface IVMRVideoStreamControl9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrvideostreamcontrol9-setstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetStreamActiveState(BOOL fActive);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmrvideostreamcontrol9-getstreamactivestate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetStreamActiveState(out BOOL lpfActive);
}
