#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/ns-d2d1_1-d2d1_creation_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct D2D1_CREATION_PROPERTIES
{
    public D2D1_THREADING_MODE threadingMode;
    public D2D1_DEBUG_LEVEL debugLevel;
    public D2D1_DEVICE_CONTEXT_OPTIONS options;
}
