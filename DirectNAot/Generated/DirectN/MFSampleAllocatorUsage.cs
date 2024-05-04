#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ne-mfidl-mfsampleallocatorusage
public enum MFSampleAllocatorUsage
{
    MFSampleAllocatorUsage_UsesProvidedAllocator = 0,
    MFSampleAllocatorUsage_UsesCustomAllocator = 1,
    MFSampleAllocatorUsage_DoesNotAllocate = 2,
}
