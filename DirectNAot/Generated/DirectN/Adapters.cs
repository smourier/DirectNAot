#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-adapters
[StructLayout(LayoutKind.Sequential)]
public partial struct Adapters
{
    public int numAdapters;
    public InlineArrayAdapter_1 adapter; // variable-length array placeholder
}
