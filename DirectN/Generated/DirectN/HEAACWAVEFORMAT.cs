#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-heaacwaveformat
public partial struct HEAACWAVEFORMAT
{
    public HEAACWAVEINFO wfInfo;
    public InlineArrayByte_1 pbAudioSpecificConfig; // variable-length array placeholder
}
