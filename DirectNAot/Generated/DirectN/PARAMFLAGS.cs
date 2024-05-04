#nullable enable
namespace DirectN;

[Flags]
public enum PARAMFLAGS : ushort
{
    PARAMFLAG_NONE = 0,
    PARAMFLAG_FIN = 1,
    PARAMFLAG_FOUT = 2,
    PARAMFLAG_FLCID = 4,
    PARAMFLAG_FRETVAL = 8,
    PARAMFLAG_FOPT = 16,
    PARAMFLAG_FHASDEFAULT = 32,
    PARAMFLAG_FHASCUSTDATA = 64,
}
