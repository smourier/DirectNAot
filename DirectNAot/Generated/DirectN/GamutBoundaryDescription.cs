#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-gamutboundarydescription
[StructLayout(LayoutKind.Sequential)]
public partial struct GamutBoundaryDescription
{
    public nint pPrimaries;
    public uint cNeutralSamples;
    public nint pNeutralSamples;
    public nint pReferenceShell;
    public nint pPlausibleShell;
    public nint pPossibleShell;
}
