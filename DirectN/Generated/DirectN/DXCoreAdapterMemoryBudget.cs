#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ns-dxcore_interface-dxcoreadaptermemorybudget
public partial struct DXCoreAdapterMemoryBudget
{
    public ulong budget;
    public ulong currentUsage;
    public ulong availableForReservation;
    public ulong currentReservation;
}
