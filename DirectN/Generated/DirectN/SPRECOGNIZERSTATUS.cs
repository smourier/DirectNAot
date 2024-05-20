#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPRECOGNIZERSTATUS
{
    public SPAUDIOSTATUS AudioStatus;
    public ulong ullRecognitionStreamPos;
    public uint ulStreamNumber;
    public uint ulNumActive;
    public Guid clsidEngine;
    public uint cLangIDs;
    public InlineArrayUInt16_20 aLangID;
    public ulong ullRecognitionStreamTime;
}
