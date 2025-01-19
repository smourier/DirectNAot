#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/propsys/ne-propsys-propdesc_relativedescription_type
public enum PROPDESC_RELATIVEDESCRIPTION_TYPE
{
    PDRDT_GENERAL = 0,
    PDRDT_DATE = 1,
    PDRDT_SIZE = 2,
    PDRDT_COUNT = 3,
    PDRDT_REVISION = 4,
    PDRDT_LENGTH = 5,
    PDRDT_DURATION = 6,
    PDRDT_SPEED = 7,
    PDRDT_RATE = 8,
    PDRDT_RATING = 9,
    PDRDT_PRIORITY = 10,
}
