#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-primaryxyzcolors
[StructLayout(LayoutKind.Sequential)]
public partial struct PrimaryXYZColors
{
    public XYZColorF red;
    public XYZColorF yellow;
    public XYZColorF green;
    public XYZColorF cyan;
    public XYZColorF blue;
    public XYZColorF magenta;
    public XYZColorF black;
    public XYZColorF white;
}
