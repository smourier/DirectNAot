#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DLSID
{
    public uint ulData1;
    public ushort usData2;
    public ushort usData3;
    public InlineArrayByte_8 abData4;
}
