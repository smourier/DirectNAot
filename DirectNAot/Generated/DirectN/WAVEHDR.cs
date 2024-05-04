#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmeapi/ns-mmeapi-wavehdr
[StructLayout(LayoutKind.Sequential)]
public partial struct WAVEHDR
{
    public PSTR lpData;
    public uint dwBufferLength;
    public uint dwBytesRecorded;
    public nuint dwUser;
    public uint dwFlags;
    public uint dwLoops;
    public nint lpNext;
    public nuint reserved;
}
