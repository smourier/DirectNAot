namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HMIXER
{
    public static readonly HMIXER Null = new();
    
    public nint Value;
}
