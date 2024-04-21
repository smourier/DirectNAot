namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIDIOUT
{
    public static readonly HMIDIOUT Null = new();
    
    public nint Value;
}
