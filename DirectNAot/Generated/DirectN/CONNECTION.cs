namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct CONNECTION
{
    public ushort usSource;
    public ushort usControl;
    public ushort usDestination;
    public ushort usTransform;
    public int lScale;
}
