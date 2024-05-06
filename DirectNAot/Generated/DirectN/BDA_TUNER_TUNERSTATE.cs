#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct BDA_TUNER_TUNERSTATE
{
    public int lResult;
    public uint ulTuneLength;
    public InlineArrayByte_1 argbTuneData; // variable-length array placeholder
}
