#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcoresegmentgroup
public enum DXCoreSegmentGroup : uint
{
    Local = 0,
    NonLocal = 1,
}
