#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/roapi/ne-roapi-ro_init_type
public enum RO_INIT_TYPE
{
    RO_INIT_SINGLETHREADED = 0,
    RO_INIT_MULTITHREADED = 1,
}
