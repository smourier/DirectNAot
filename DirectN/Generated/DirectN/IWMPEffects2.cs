#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/effects/nn-effects-iwmpeffects2
[GeneratedComInterface, Guid("695386ec-aa3c-4618-a5e1-dd9a8b987632")]
public partial interface IWMPEffects2 : IWMPEffects
{
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-setcore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCore([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPCore>))] IWMPCore pPlayer);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(HWND hwndParent);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-destroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Destroy();
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-notifynewmedia
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT NotifyNewMedia([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IWMPMedia>))] IWMPMedia pMedia);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-onwindowmessage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnWindowMessage(uint msg, WPARAM WParam, LPARAM LParam, ref LRESULT plResultParam);
    
    // https://learn.microsoft.com/windows/win32/api/effects/nf-effects-iwmpeffects2-renderwindowed
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT RenderWindowed(ref TimedLevel pData, BOOL fRequiredRender);
}
