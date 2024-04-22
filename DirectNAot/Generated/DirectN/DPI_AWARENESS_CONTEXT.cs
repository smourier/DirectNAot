namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DPI_AWARENESS_CONTEXT
{
    public static readonly DPI_AWARENESS_CONTEXT Null = new();
    
    public nint Value;
}
