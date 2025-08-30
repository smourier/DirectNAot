#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_video_processor_color_space
public partial struct D3D11_VIDEO_PROCESSOR_COLOR_SPACE : IEquatable<D3D11_VIDEO_PROCESSOR_COLOR_SPACE>, IValueGet<uint>
{
    public static readonly D3D11_VIDEO_PROCESSOR_COLOR_SPACE Null = new();
    
    public uint _bitfield;
    
    public D3D11_VIDEO_PROCESSOR_COLOR_SPACE(uint value) => this._bitfield = value;
    public override string ToString() => $"0x{_bitfield:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_VIDEO_PROCESSOR_COLOR_SPACE value && Equals(value);
    public readonly bool Equals(D3D11_VIDEO_PROCESSOR_COLOR_SPACE other) => other._bitfield == _bitfield;
    public override readonly int GetHashCode() => _bitfield.GetHashCode();
    public static bool operator ==(D3D11_VIDEO_PROCESSOR_COLOR_SPACE left, D3D11_VIDEO_PROCESSOR_COLOR_SPACE right) => left.Equals(right);
    public static bool operator !=(D3D11_VIDEO_PROCESSOR_COLOR_SPACE left, D3D11_VIDEO_PROCESSOR_COLOR_SPACE right) => !left.Equals(right);
    public static implicit operator uint(D3D11_VIDEO_PROCESSOR_COLOR_SPACE value) => value._bitfield;
    public static implicit operator D3D11_VIDEO_PROCESSOR_COLOR_SPACE(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => _bitfield;
    readonly object? IValueGet.GetValue() => _bitfield;
}
