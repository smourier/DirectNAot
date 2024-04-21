namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HWND
{
    public static readonly HWND Null = new();
    
    public nint Value;
}
