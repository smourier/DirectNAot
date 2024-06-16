#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/nn-mfidl-imfratecontrol
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("88ddcd21-03c3-4275-91ed-55ee3929328f")]
public partial interface IMFRateControl
{
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfratecontrol-setrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRate(BOOL fThin, float flRate);
    
    // https://learn.microsoft.com/windows/win32/api/mfidl/nf-mfidl-imfratecontrol-getrate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetRate(ref BOOL pfThin, ref float pflRate);
}
