#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/tablet/bitmap-element
[StructLayout(LayoutKind.Sequential)]
public partial struct Bitmap
{
    public static readonly Bitmap Null = new();
    
    public nint Value;
}
