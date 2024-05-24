#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midiproptimediv
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIPROPTIMEDIV
{
    public uint cbStruct;
    public uint dwTimeDiv;
}
