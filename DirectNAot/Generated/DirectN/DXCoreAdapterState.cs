namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcoreadapterstate
public enum DXCoreAdapterState : uint
{
    IsDriverUpdateInProgress = 0,
    AdapterMemoryBudget = 1,
}
