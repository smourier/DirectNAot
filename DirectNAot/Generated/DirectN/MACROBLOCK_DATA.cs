namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct MACROBLOCK_DATA
{
    public uint flags;
    public short motionVectorX;
    public short motionVectorY;
    public int QPDelta;
}
