namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nn-inkpresenterdesktop-iinkdesktophost
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("4ce7d875-a981-4140-a1ff-ad93258e8d59")]
public partial interface IInkDesktopHost
{
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkdesktophost-queueworkitem
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT QueueWorkItem(IInkHostWorkItem workItem);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkdesktophost-createinkpresenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateInkPresenter(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkdesktophost-createandinitializeinkpresenter
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateAndInitializeInkPresenter(nint rootVisual, float width, float height, in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
}
