#nullable enable
namespace DirectN;

public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP : IEquatable<D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP>, IValueGet<uint>
{
    public static readonly D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP Null = new();
    
    public uint MapSourcePreferenceRanking;
    
    public D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP(uint value) => this.MapSourcePreferenceRanking = value;
    public override readonly string ToString() => $"0x{MapSourcePreferenceRanking:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP value && Equals(value);
    public readonly bool Equals(D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP other) => other.MapSourcePreferenceRanking == MapSourcePreferenceRanking;
    public override readonly int GetHashCode() => MapSourcePreferenceRanking.GetHashCode();
    public static bool operator ==(D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP left, D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP right) => left.Equals(right);
    public static bool operator !=(D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP left, D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP right) => !left.Equals(right);
    public static implicit operator uint(D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP value) => value.MapSourcePreferenceRanking;
    public static implicit operator D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOLUTION_SUPPORT_QPMAP(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MapSourcePreferenceRanking;
    readonly object? IValueGet.GetValue() => MapSourcePreferenceRanking;
}
