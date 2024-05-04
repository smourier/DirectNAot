#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECORESULTTIMES
{
    public FILETIME ftStreamTime;
    public ulong ullLength;
    public uint dwTickCount;
    public ulong ullStart;
}
