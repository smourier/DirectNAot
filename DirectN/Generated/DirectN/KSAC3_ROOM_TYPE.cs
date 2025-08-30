#nullable enable
namespace DirectN;

public partial struct KSAC3_ROOM_TYPE : IValueGet<BOOL>
{
    public BOOL fLargeRoom;
    
    readonly BOOL IValueGet<BOOL>.GetValue() => fLargeRoom;
    readonly object? IValueGet.GetValue() => fLargeRoom;
}
