namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct PORT_DATA_LIST_1
{
    public uint dwVersion;
    public uint cPortData;
    public InlineArrayPORT_DATA_21 pPortData; // variable-length array placeholder
}
