#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/avifmt/ns-avifmt-avipalchange
[StructLayout(LayoutKind.Sequential)]
public partial struct AVIPALCHANGE
{
    public byte bFirstEntry;
    public byte bNumEntries;
    public ushort wFlags;
    public InlineArrayPALETTEENTRY1 peNew;
}
