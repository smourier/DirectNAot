#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vfw/ns-vfw-videohdr
[StructLayout(LayoutKind.Sequential)]
public partial struct VIDEOHDR
{
    public nint lpData;
    public uint dwBufferLength;
    public uint dwBytesUsed;
    public uint dwTimeCaptured;
    public nuint dwUser;
    public uint dwFlags;
    public InlineArrayUIntPtr_4 dwReserved;
}
