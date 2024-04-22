namespace DirectN;

[GeneratedComInterface, Guid("35dbf59e-e3f9-45b0-81e7-fe75f4145dc9")]
public partial interface IDesktopWindowTargetInterop
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT get_Hwnd(out HWND value);
}
