#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/combaseapi/ns-combaseapi-serverinformation
[StructLayout(LayoutKind.Sequential)]
public partial struct ServerInformation
{
    public uint dwServerPid;
    public uint dwServerTid;
    public ulong ui64ServerAddress;
}
