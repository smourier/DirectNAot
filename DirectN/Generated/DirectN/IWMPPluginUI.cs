#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpplug/nn-wmpplug-iwmppluginui
[GeneratedComInterface, Guid("4c5e8f9f-ad3e-4bf9-9753-fcd30d6d38dd")]
public partial interface IWMPPluginUI
{
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-setcore
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCore(IWMPCore pCore);
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-create
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Create(HWND hwndParent, ref HWND phwndWindow);
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-destroy
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Destroy();
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-displaypropertypage
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DisplayPropertyPage(HWND hwndParent);
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-getproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetProperty(PWSTR pwszName, ref VARIANT pvarProperty);
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-setproperty
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetProperty(PWSTR pwszName, in VARIANT pvarProperty);
    
    // https://learn.microsoft.com/windows/win32/api/wmpplug/nf-wmpplug-iwmppluginui-translateaccelerator
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT TranslateAccelerator(ref MSG lpmsg);
}
