namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmpdevices/ns-wmpdevices-wmp_wmdm_metadata_round_trip_device2pc
[StructLayout(LayoutKind.Sequential)]
public partial struct WMP_WMDM_METADATA_ROUND_TRIP_DEVICE2PC
{
    public uint dwCurrentTransactionID;
    public uint dwReturnedObjectCount;
    public uint dwUnretrievedObjectCount;
    public uint dwDeletedObjectStartingOffset;
    public uint dwFlags;
    public InlineArraySystemChar1 wsObjectPathnameList; // variable-length array placeholder
}
