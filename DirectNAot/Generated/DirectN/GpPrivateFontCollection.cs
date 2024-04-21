namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpPrivateFontCollection
{
    public static readonly GpPrivateFontCollection Null = new();
    
    public nint Value;
}
