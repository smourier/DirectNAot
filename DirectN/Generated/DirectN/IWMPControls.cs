#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmp/nn-wmp-iwmpcontrols
[GeneratedComInterface, Guid("74c09e02-f828-11d2-a74b-00a0c905f36e")]
public partial interface IWMPControls : IDispatch
{
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-get_isavailable
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_isAvailable(BSTR bstrItem, ref VARIANT_BOOL pIsAvailable);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-play
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT play();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-stop
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT stop();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-pause
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT pause();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-fastforward
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT fastForward();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-fastreverse
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT fastReverse();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-get_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentPosition(ref double pdCurrentPosition);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-put_currentposition
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentPosition(double dCurrentPosition);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-get_currentpositionstring
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentPositionString(ref BSTR pbstrCurrentPosition);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-next
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT next();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-previous
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT previous();
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-get_currentitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentItem(out IWMPMedia ppIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-put_currentitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentItem(IWMPMedia pIWMPMedia);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-get_currentmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_currentMarker(ref int plMarker);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-put_currentmarker
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_currentMarker(int lMarker);
    
    // https://learn.microsoft.com/windows/win32/api/wmp/nf-wmp-iwmpcontrols-playitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT playItem(IWMPMedia pIWMPMedia);
}
