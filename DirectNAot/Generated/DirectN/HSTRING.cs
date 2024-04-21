namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring
[StructLayout(LayoutKind.Sequential)]
public partial struct HSTRING
{
    public static readonly HSTRING Null = new();
    
    public nint Value;
}
