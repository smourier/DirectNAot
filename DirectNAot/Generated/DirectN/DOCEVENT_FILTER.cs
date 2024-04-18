namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct DOCEVENT_FILTER
{
    public uint cbSize;
    public uint cElementsAllocated;
    public uint cElementsNeeded;
    public uint cElementsReturned;
    public InlineArrayUInt321 aDocEventCall; // variable-length array placeholder
}
