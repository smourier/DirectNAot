namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxcore_interface/ns-dxcore_interface-dxcoreadaptermemorybudget
[StructLayout(LayoutKind.Sequential)]
public partial struct DXCoreAdapterMemoryBudget
{
    public ulong budget;
    public ulong currentUsage;
    public ulong availableForReservation;
    public ulong currentReservation;
}
