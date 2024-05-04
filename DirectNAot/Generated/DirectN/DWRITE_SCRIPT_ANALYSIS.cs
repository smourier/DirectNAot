#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/ns-dwrite-dwrite_script_analysis
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_SCRIPT_ANALYSIS
{
    public ushort script;
    public DWRITE_SCRIPT_SHAPES shapes;
}
