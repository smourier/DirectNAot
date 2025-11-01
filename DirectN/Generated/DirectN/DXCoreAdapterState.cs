#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcoreadapterstate
public enum DXCoreAdapterState : uint
{
    IsDriverUpdateInProgress = 0,
    AdapterMemoryBudget = 1,
    AdapterMemoryUsageBytes = 2,
    AdapterMemoryUsageByProcessBytes = 3,
    AdapterEngineRunningTimeMicroseconds = 4,
    AdapterEngineRunningTimeByProcessMicroseconds = 5,
    AdapterTemperatureCelsius = 6,
    AdapterInUseProcessCount = 7,
    AdapterInUseProcessSet = 8,
    AdapterEngineFrequencyHertz = 9,
    AdapterMemoryFrequencyHertz = 10,
}
