#nullable enable
namespace DirectN;

public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP : IEquatable<D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP>, IValueGet<uint>
{
    public static readonly D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP Null = new();
    
    public uint QualityVsSpeed;
    
    public D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP(uint value) => this.QualityVsSpeed = value;
    public override string ToString() => $"0x{QualityVsSpeed:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP value && Equals(value);
    public readonly bool Equals(D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP other) => other.QualityVsSpeed == QualityVsSpeed;
    public override readonly int GetHashCode() => QualityVsSpeed.GetHashCode();
    public static bool operator ==(D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP left, D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP right) => left.Equals(right);
    public static bool operator !=(D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP left, D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP right) => !left.Equals(right);
    public static implicit operator uint(D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP value) => value.QualityVsSpeed;
    public static implicit operator D3D12_VIDEO_ENCODER_RATE_CONTROL_ABSOLUTE_QP_MAP(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => QualityVsSpeed;
    readonly object? IValueGet.GetValue() => QualityVsSpeed;
}
