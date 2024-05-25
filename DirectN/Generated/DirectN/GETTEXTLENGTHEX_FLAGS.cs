#nullable enable
namespace DirectN;

[Flags]
public enum GETTEXTLENGTHEX_FLAGS : uint
{
    GTL_DEFAULT = 0,
    GTL_USECRLF = 1,
    GTL_PRECISE = 2,
    GTL_CLOSE = 4,
    GTL_NUMCHARS = 8,
    GTL_NUMBYTES = 16,
}
