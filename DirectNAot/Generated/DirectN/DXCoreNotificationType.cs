namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcorenotificationtype
public enum DXCoreNotificationType : uint
{
    AdapterListStale = 0,
    AdapterNoLongerValid = 1,
    AdapterBudgetChange = 2,
    AdapterHardwareContentProtectionTeardown = 3,
}
