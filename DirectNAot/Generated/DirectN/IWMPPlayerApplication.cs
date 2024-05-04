#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpplayerapplication
[GeneratedComInterface, Guid("40897764-ceab-47be-ad4a-8e28537f9bbf")]
public partial interface IWMPPlayerApplication : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerapplication-switchtoplayerapplication
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT switchToPlayerApplication();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerapplication-switchtocontrol
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT switchToControl();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerapplication-get_playerdocked
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_playerDocked(ref VARIANT_BOOL pbPlayerDocked);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpplayerapplication-get_hasdisplay
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_hasDisplay(ref VARIANT_BOOL pbHasDisplay);
}
