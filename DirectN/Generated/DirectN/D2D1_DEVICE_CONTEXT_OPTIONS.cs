#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ne-d2d1_1-d2d1_device_context_options
[Flags]
public enum D2D1_DEVICE_CONTEXT_OPTIONS
{
    D2D1_DEVICE_CONTEXT_OPTIONS_NONE = 0,
    D2D1_DEVICE_CONTEXT_OPTIONS_ENABLE_MULTITHREADED_OPTIMIZATIONS = 1,
}
