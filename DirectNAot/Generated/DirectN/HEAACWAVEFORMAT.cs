namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mmreg/ns-mmreg-heaacwaveformat
[StructLayout(LayoutKind.Sequential)]
public partial struct HEAACWAVEFORMAT
{
    public HEAACWAVEINFO wfInfo;
    public InlineArrayByte1 pbAudioSpecificConfig; // variable-length array placeholder
}
