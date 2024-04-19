namespace DirectN;

[GeneratedComInterface, Guid("96740bfa-c56a-45d1-a3a4-762914d4ade9")]
public partial interface IWMPNodeWindowed
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetOwnerWindow(nint hwnd);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOwnerWindow(ref nint phwnd);
}
