#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/nn-vmr9-ivmraspectratiocontrol9
[SupportedOSPlatform("windows5.1.2600")]
[GeneratedComInterface, Guid("00d96c29-bbde-4efc-9901-bb5036392146")]
public partial interface IVMRAspectRatioControl9
{
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmraspectratiocontrol9-getaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetAspectRatioMode(out uint lpdwARMode);
    
    // https://learn.microsoft.com/windows/win32/api/vmr9/nf-vmr9-ivmraspectratiocontrol9-setaspectratiomode
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAspectRatioMode(uint dwARMode);
}
