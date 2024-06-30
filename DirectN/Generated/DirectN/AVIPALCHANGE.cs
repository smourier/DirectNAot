#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/avifmt/ns-avifmt-avipalchange
public partial struct AVIPALCHANGE
{
    public byte bFirstEntry;
    public byte bNumEntries;
    public ushort wFlags;
    public InlineArrayPALETTEENTRY_1 peNew;
}
