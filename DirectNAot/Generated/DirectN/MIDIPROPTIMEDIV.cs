namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midiproptimediv
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIPROPTIMEDIV
{
    public uint cbStruct;
    public uint dwTimeDiv;
}
