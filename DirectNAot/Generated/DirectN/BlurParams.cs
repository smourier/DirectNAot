namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BlurParams
{
    public float radius;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool expandEdge;
}
