#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-sources
[StructLayout(LayoutKind.Sequential)]
public partial struct Sources
{
    public uint sourceId;
    public int numTargets;
    public InlineArrayUInt321 aTargets; // variable-length array placeholder
}
