#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/objbase/ne-objbase-coinit
[Flags]
public enum COINIT
{
    COINIT_APARTMENTTHREADED = 2,
    COINIT_MULTITHREADED = 0,
    COINIT_DISABLE_OLE1DDE = 4,
    COINIT_SPEED_OVER_MEMORY = 8,
}
