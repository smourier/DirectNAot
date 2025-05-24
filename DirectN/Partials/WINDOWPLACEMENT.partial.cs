namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-windowplacement
public partial struct WINDOWPLACEMENT
{
    public readonly bool IsMinimized => (SHOW_WINDOW_CMD)showCmd == SHOW_WINDOW_CMD.SW_SHOWMINIMIZED;
    public unsafe readonly bool IsValid => length == sizeof(WINDOWPLACEMENT);

    [SupportedOSPlatform("windows5.0")]
    public readonly bool SetPlacement(HWND handle) => Functions.SetWindowPlacement(handle, this);

    [SupportedOSPlatform("windows5.0")]
    public unsafe static WINDOWPLACEMENT GetPlacement(HWND handle, bool throwOnError = false)
    {
        var wp = new WINDOWPLACEMENT();
        if (handle == 0)
            return wp;

        wp.length = (uint)sizeof(WINDOWPLACEMENT);
        if (!Functions.GetWindowPlacement(handle, ref wp))
        {
            if (throwOnError)
                throw new Win32Exception(Marshal.GetLastPInvokeError());

            return new WINDOWPLACEMENT();
        }
        return wp;
    }
}
