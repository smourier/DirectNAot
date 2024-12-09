namespace DirectN;

[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("C5435A42-8D43-4E7B-A68A-EF311E392087")]
public partial interface IPrintManagerInterop : IInspectable
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetForWindow(HWND appWindow, in Guid riid, out nint printManager);

    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ShowPrintUIForWindowAsync(HWND appWindow, in Guid riid, out nint asyncOperation);
}
