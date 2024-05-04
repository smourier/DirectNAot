#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-adapter
[StructLayout(LayoutKind.Sequential)]
public partial struct Adapter
{
    public InlineArraySystemChar128 AdapterName;
    public int numSources;
    public InlineArraySources1 sources; // variable-length array placeholder
}
