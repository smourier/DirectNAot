namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-metarecord
[StructLayout(LayoutKind.Sequential)]
public partial struct METARECORD
{
    public uint rdSize;
    public ushort rdFunction;
    public InlineArrayUInt161 rdParm; // variable-length array placeholder
}
