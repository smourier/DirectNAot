#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpdevices/ns-wmpdevices-wmp_wmdm_metadata_round_trip_pc2device
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct WMP_WMDM_METADATA_ROUND_TRIP_PC2DEVICE
{
    public uint dwChangesSinceTransactionID;
    public uint dwResultSetStartingIndex;
}
