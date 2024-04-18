namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct EXTTEXTMETRIC
{
    public short emSize;
    public short emPointSize;
    public short emOrientation;
    public short emMasterHeight;
    public short emMinScale;
    public short emMaxScale;
    public short emMasterUnits;
    public short emCapHeight;
    public short emXHeight;
    public short emLowerCaseAscent;
    public short emLowerCaseDescent;
    public short emSlant;
    public short emSuperScript;
    public short emSubScript;
    public short emSuperScriptSize;
    public short emSubScriptSize;
    public short emUnderlineOffset;
    public short emUnderlineWidth;
    public short emDoubleUpperUnderlineOffset;
    public short emDoubleLowerUnderlineOffset;
    public short emDoubleUpperUnderlineWidth;
    public short emDoubleLowerUnderlineWidth;
    public short emStrikeOutOffset;
    public short emStrikeOutWidth;
    public ushort emKernPairs;
    public ushort emKernTracks;
}
