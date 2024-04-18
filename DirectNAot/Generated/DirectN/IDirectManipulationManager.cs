namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/directmanipulation/nn-directmanipulation-idirectmanipulationmanager
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("fbf5d3b4-70c7-4163-9322-5a6f660d6fbc")]
public partial interface IDirectManipulationManager
{
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-activate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Activate(HWND window);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-deactivate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT Deactivate(HWND window);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-registerhittesttarget
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RegisterHitTestTarget(HWND window, HWND hitTestWindow, DIRECTMANIPULATION_HITTEST_TYPE type);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-processinput
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT ProcessInput(in MSG message, [MarshalAs(UnmanagedType.U4)] out bool handled);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-getupdatemanager
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetUpdateManager(in Guid riid, out nint @object);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-createviewport
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateViewport(IDirectManipulationFrameInfoProvider frameInfo, HWND window, in Guid riid, out nint @object);
    
    // https://learn.microsoft.com/windows/win32/api/directmanipulation/nf-directmanipulation-idirectmanipulationmanager-createcontent
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT CreateContent(IDirectManipulationFrameInfoProvider frameInfo, in Guid clsid, in Guid riid, out nint @object);
}
