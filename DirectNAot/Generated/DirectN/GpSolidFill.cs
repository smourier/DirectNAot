namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct GpSolidFill
{
    public static readonly GpSolidFill Null = new();
    
    public nint Value;
}
