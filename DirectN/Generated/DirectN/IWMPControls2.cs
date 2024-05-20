#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcontrols2
[GeneratedComInterface, Guid("6f030d25-0890-480f-9775-1f7e40ab5b8e")]
public partial interface IWMPControls2 : IWMPControls
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols2-step
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT step(int lStep);
}
