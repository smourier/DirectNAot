#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/oaidl/ns-oaidl-tlibattr
[StructLayout(LayoutKind.Sequential)]
public partial struct TLIBATTR
{
    public Guid guid;
    public uint lcid;
    public SYSKIND syskind;
    public ushort wMajorVerNum;
    public ushort wMinorVerNum;
    public ushort wLibFlags;
}
