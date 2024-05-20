#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/shellscalingapi/ne-shellscalingapi-process_dpi_awareness
public enum PROCESS_DPI_AWARENESS
{
    PROCESS_DPI_UNAWARE = 0,
    PROCESS_SYSTEM_DPI_AWARE = 1,
    PROCESS_PER_MONITOR_DPI_AWARE = 2,
}
