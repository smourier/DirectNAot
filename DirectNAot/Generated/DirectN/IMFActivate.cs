namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/nn-mfobjects-imfactivate
[SupportedOSPlatform("windows6.0.6000")]
[GeneratedComInterface, Guid("7fee9e9a-4a89-47a6-899c-b6a53a70fb67")]
public partial interface IMFActivate : IMFAttributes
{
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfactivate-activateobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ActivateObject(in Guid riid, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<object>))] out object /* void */ ppv);
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfactivate-shutdownobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShutdownObject();
    
    // https://learn.microsoft.com/windows/win32/api/mfobjects/nf-mfobjects-imfactivate-detachobject
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT DetachObject();
}
