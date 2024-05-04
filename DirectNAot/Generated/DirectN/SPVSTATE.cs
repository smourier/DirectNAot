#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct SPVSTATE
{
    public SPVACTIONS eAction;
    public ushort LangID;
    public ushort wReserved;
    public int EmphAdj;
    public int RateAdj;
    public uint Volume;
    public SPVPITCH PitchAdj;
    public uint SilenceMSecs;
    public nint pPhoneIds;
    public SPPARTOFSPEECH ePartOfSpeech;
    public SPVCONTEXT Context;
}
