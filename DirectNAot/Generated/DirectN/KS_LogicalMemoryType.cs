namespace DirectN;

public enum KS_LogicalMemoryType
{
    KS_MemoryTypeDontCare = 0,
    KS_MemoryTypeKernelPaged = 1,
    KS_MemoryTypeKernelNonPaged = 2,
    KS_MemoryTypeDeviceHostMapped = 3,
    KS_MemoryTypeDeviceSpecific = 4,
    KS_MemoryTypeUser = 5,
    KS_MemoryTypeAnyHost = 6,
}
