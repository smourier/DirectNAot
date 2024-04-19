namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/nn-mfmediaengine-imfcdmsuspendnotify
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("7a5645d2-43bd-47fd-87b7-dcd24cc7d692")]
public partial interface IMFCdmSuspendNotify
{
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfcdmsuspendnotify-begin
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Begin();
    
    // https://learn.microsoft.com/windows/win32/api/mfmediaengine/nf-mfmediaengine-imfcdmsuspendnotify-end
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT End();
}
