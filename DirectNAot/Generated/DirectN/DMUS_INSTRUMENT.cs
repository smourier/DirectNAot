namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DMUS_INSTRUMENT
{
    public uint ulPatch;
    public uint ulFirstRegionIdx;
    public uint ulGlobalArtIdx;
    public uint ulFirstExtCkIdx;
    public uint ulCopyrightIdx;
    public uint ulFlags;
}
