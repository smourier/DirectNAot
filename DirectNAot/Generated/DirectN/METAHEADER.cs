namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-metaheader
[StructLayout(LayoutKind.Sequential)]
public partial struct METAHEADER
{
    public ushort mtType;
    public ushort mtHeaderSize;
    public ushort mtVersion;
    public uint mtSize;
    public ushort mtNoObjects;
    public uint mtMaxRecord;
    public ushort mtNoParameters;
}
