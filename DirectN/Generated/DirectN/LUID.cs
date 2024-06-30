#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/ntdef/ns-ntdef-luid
public partial struct LUID
{
    public uint LowPart;
    public int HighPart;
}
