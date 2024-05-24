#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct BadSampleInfo
{
    public HRESULT hrReason;
}
