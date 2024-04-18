namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct HEAPALIAS
{
    public nuint fpVidMem;
    public nint lpAlias;
    public uint dwAliasSize;
}
