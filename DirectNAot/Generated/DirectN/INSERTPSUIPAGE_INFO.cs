namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct INSERTPSUIPAGE_INFO
{
    public ushort cbSize;
    public byte Type;
    public byte Mode;
    public nuint dwData1;
    public nuint dwData2;
    public nuint dwData3;
}
