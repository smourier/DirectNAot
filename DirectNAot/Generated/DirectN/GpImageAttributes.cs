namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpImageAttributes
{
    public static readonly GpImageAttributes Null = new();
    
    public nint Value;
}
