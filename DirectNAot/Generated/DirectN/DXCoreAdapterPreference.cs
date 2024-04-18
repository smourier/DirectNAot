namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcoreadapterpreference
public enum DXCoreAdapterPreference : uint
{
    Hardware = 0,
    MinimumPower = 1,
    HighPerformance = 2,
}
