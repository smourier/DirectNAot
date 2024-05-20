#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct KSAC3_ROOM_TYPE
{
    [MarshalAs(UnmanagedType.U4)]
    public bool fLargeRoom;
}
