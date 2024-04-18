namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ne-dxcore_interface-dxcoreadapterproperty
public enum DXCoreAdapterProperty : uint
{
    InstanceLuid = 0,
    DriverVersion = 1,
    DriverDescription = 2,
    HardwareID = 3,
    KmdModelVersion = 4,
    ComputePreemptionGranularity = 5,
    GraphicsPreemptionGranularity = 6,
    DedicatedAdapterMemory = 7,
    DedicatedSystemMemory = 8,
    SharedSystemMemory = 9,
    AcgCompatible = 10,
    IsHardware = 11,
    IsIntegrated = 12,
    IsDetachable = 13,
    HardwareIDParts = 14,
}
