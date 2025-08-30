#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11shadertracing/ns-d3d11shadertracing-d3d11_hull_shader_trace_desc
public partial struct D3D11_HULL_SHADER_TRACE_DESC : IEquatable<D3D11_HULL_SHADER_TRACE_DESC>, IValueGet<ulong>
{
    public static readonly D3D11_HULL_SHADER_TRACE_DESC Null = new();
    
    public ulong Invocation;
    
    public D3D11_HULL_SHADER_TRACE_DESC(ulong value) => this.Invocation = value;
    public override string ToString() => $"0x{Invocation:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D11_HULL_SHADER_TRACE_DESC value && Equals(value);
    public readonly bool Equals(D3D11_HULL_SHADER_TRACE_DESC other) => other.Invocation == Invocation;
    public override readonly int GetHashCode() => Invocation.GetHashCode();
    public static bool operator ==(D3D11_HULL_SHADER_TRACE_DESC left, D3D11_HULL_SHADER_TRACE_DESC right) => left.Equals(right);
    public static bool operator !=(D3D11_HULL_SHADER_TRACE_DESC left, D3D11_HULL_SHADER_TRACE_DESC right) => !left.Equals(right);
    public static implicit operator ulong(D3D11_HULL_SHADER_TRACE_DESC value) => value.Invocation;
    public static implicit operator D3D11_HULL_SHADER_TRACE_DESC(ulong value) => new(value);
    
    readonly ulong IValueGet<ulong>.GetValue() => Invocation;
    readonly object? IValueGet.GetValue() => Invocation;
}
