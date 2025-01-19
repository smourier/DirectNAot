#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_aggregation_type
public enum PROPDESC_AGGREGATION_TYPE
{
    PDAT_DEFAULT = 0,
    PDAT_FIRST = 1,
    PDAT_SUM = 2,
    PDAT_AVERAGE = 3,
    PDAT_DATERANGE = 4,
    PDAT_UNION = 5,
    PDAT_MAX = 6,
    PDAT_MIN = 7,
}
