namespace DirectN;

[StructLayout(LayoutKind.Explicit)]
public partial struct FLOAT_LONG
{
    [FieldOffset(0)]
    public float e;
    
    [FieldOffset(0)]
    public int l;
}
