namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring
[StructLayout(LayoutKind.Sequential)]
public partial struct HSTRING
{
    public nint Value;
}
