#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/presentation/ne-presentation-presentstatus
public enum PresentStatus
{
    PresentStatus_Queued = 0,
    PresentStatus_Skipped = 1,
    PresentStatus_Canceled = 2,
}
