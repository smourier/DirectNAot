#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DIALOGICOKIADPCMWAVEFORMAT : IValueGet<WAVEFORMATEX>
{
    public WAVEFORMATEX ewf;
    
    readonly WAVEFORMATEX IValueGet<WAVEFORMATEX>.GetValue() => ewf;
    readonly object? IValueGet.GetValue() => ewf;
}
