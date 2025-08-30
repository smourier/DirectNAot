#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct OLIGSMWAVEFORMAT : IValueGet<WAVEFORMATEX>
{
    public WAVEFORMATEX wfx;
    
    readonly WAVEFORMATEX IValueGet<WAVEFORMATEX>.GetValue() => wfx;
    readonly object? IValueGet.GetValue() => wfx;
}
