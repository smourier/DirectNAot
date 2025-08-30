#nullable enable
namespace DirectN;

public partial struct KSPROPERTY_SPPAL : IValueGet<KS_DVD_YUV[]>
{
    public InlineArrayKS_DVD_YUV_16 sppal;
    
    readonly KS_DVD_YUV[]? IValueGet<KS_DVD_YUV[]>.GetValue() => ((ReadOnlySpan<KS_DVD_YUV>)sppal).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<KS_DVD_YUV>)sppal).ToArray();
}
