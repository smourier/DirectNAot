#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite_1/ns-dwrite_1-dwrite_script_properties
[StructLayout(LayoutKind.Sequential)]
public partial struct DWRITE_SCRIPT_PROPERTIES
{
    public uint isoScriptCode;
    public uint isoScriptNumber;
    public uint clusterLookahead;
    public uint justificationCharacter;
    public uint _bitfield;
}
