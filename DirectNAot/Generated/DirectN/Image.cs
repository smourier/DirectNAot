#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/windowsribbon/windowsribbon-element-image
[StructLayout(LayoutKind.Sequential)]
public partial struct Image
{
    public static readonly Image Null = new();
    
    public nint Value;
}
