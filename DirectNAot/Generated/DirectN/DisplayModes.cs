#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/cloneviewhelper/ns-cloneviewhelper-displaymodes
[StructLayout(LayoutKind.Sequential)]
public partial struct DisplayModes
{
    public int numDisplayModes;
    public InlineArrayDisplayMode1 displayMode; // variable-length array placeholder
}
