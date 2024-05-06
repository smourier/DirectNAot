#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-midihdr
[StructLayout(LayoutKind.Sequential)]
public partial struct MIDIHDR
{
    public PSTR lpData;
    public uint dwBufferLength;
    public uint dwBytesRecorded;
    public nuint dwUser;
    public uint dwFlags;
    public nint lpNext;
    public nuint reserved;
    public uint dwOffset;
    public InlineArrayUIntPtr_8 dwReserved;
}
