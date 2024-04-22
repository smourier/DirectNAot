namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nn-inkpresenterdesktop-iinkpresenterdesktop
[SupportedOSPlatform("windows10.0.10240")]
[GeneratedComInterface, Guid("73f3c0d9-2e8b-48f3-895e-20cbd27b723b")]
public partial interface IInkPresenterDesktop
{
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkpresenterdesktop-setrootvisual
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetRootVisual(nint rootVisual, nint device);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkpresenterdesktop-setcommitrequesthandler
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetCommitRequestHandler(IInkCommitRequestHandler handler);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkpresenterdesktop-getsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetSize(out float width, out float height);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkpresenterdesktop-setsize
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetSize(float width, float height);
    
    // https://learn.microsoft.com/windows/win32/api/inkpresenterdesktop/nf-inkpresenterdesktop-iinkpresenterdesktop-onhighcontrastchanged
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT OnHighContrastChanged();
}
