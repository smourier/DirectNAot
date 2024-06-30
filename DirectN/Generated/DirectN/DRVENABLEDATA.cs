#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-drvenabledata
public partial struct DRVENABLEDATA
{
    public uint iDriverVersion;
    public uint c;
    public nint pdrvfn;
}
