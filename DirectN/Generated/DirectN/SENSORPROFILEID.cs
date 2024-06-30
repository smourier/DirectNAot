#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfidl/ns-mfidl-sensorprofileid
public partial struct SENSORPROFILEID
{
    public Guid Type;
    public uint Index;
    public uint Unused;
}
