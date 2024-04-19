namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPSHORTCUTPAIRLIST
{
    public uint ulSize;
    public nint pvBuffer;
    public nint pFirstShortcutPair;
}
