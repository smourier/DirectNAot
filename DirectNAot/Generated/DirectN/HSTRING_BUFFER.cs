#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/WinRT/hstring-buffer
[StructLayout(LayoutKind.Sequential)]
public partial struct HSTRING_BUFFER
{
    public static readonly HSTRING_BUFFER Null = new();
    
    public nint Value;
}
