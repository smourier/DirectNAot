#nullable enable
namespace DirectN;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct BadSampleInfo : IValueGet<HRESULT>
{
    public HRESULT hrReason;
    
    readonly HRESULT IValueGet<HRESULT>.GetValue() => hrReason;
    readonly object? IValueGet.GetValue() => hrReason;
}
