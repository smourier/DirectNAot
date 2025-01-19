#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_searchinfo_flags
[Flags]
public enum PROPDESC_SEARCHINFO_FLAGS
{
    PDSIF_DEFAULT = 0,
    PDSIF_ININVERTEDINDEX = 1,
    PDSIF_ISCOLUMN = 2,
    PDSIF_ISCOLUMNSPARSE = 4,
    PDSIF_ALWAYSINCLUDE = 8,
    PDSIF_USEFORTYPEAHEAD = 16,
}
