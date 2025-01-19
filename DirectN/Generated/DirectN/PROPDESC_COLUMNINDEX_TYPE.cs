#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_columnindex_type
public enum PROPDESC_COLUMNINDEX_TYPE
{
    PDCIT_NONE = 0,
    PDCIT_ONDISK = 1,
    PDCIT_INMEMORY = 2,
    PDCIT_ONDEMAND = 3,
    PDCIT_ONDISKALL = 4,
    PDCIT_ONDISKVECTOR = 5,
}
