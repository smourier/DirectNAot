#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva9typ/ns-dxva9typ-dxva_coppsetprotectionlevelcmddata
[StructLayout(LayoutKind.Sequential)]
public partial struct DXVA_COPPSetProtectionLevelCmdData
{
    public uint ProtType;
    public uint ProtLevel;
    public uint ExtendedInfoChangeMask;
    public uint ExtendedInfoData;
}
