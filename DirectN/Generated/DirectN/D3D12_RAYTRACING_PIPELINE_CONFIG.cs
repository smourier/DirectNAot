#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/ns-d3d12-d3d12_raytracing_pipeline_config
public partial struct D3D12_RAYTRACING_PIPELINE_CONFIG : IEquatable<D3D12_RAYTRACING_PIPELINE_CONFIG>, IValueGet<uint>
{
    public static readonly D3D12_RAYTRACING_PIPELINE_CONFIG Null = new();
    
    public uint MaxTraceRecursionDepth;
    
    public D3D12_RAYTRACING_PIPELINE_CONFIG(uint value) => this.MaxTraceRecursionDepth = value;
    public override readonly string ToString() => $"0x{MaxTraceRecursionDepth:x}";
    
    public override readonly bool Equals(object? obj) => obj is D3D12_RAYTRACING_PIPELINE_CONFIG value && Equals(value);
    public readonly bool Equals(D3D12_RAYTRACING_PIPELINE_CONFIG other) => other.MaxTraceRecursionDepth == MaxTraceRecursionDepth;
    public override readonly int GetHashCode() => MaxTraceRecursionDepth.GetHashCode();
    public static bool operator ==(D3D12_RAYTRACING_PIPELINE_CONFIG left, D3D12_RAYTRACING_PIPELINE_CONFIG right) => left.Equals(right);
    public static bool operator !=(D3D12_RAYTRACING_PIPELINE_CONFIG left, D3D12_RAYTRACING_PIPELINE_CONFIG right) => !left.Equals(right);
    public static implicit operator uint(D3D12_RAYTRACING_PIPELINE_CONFIG value) => value.MaxTraceRecursionDepth;
    public static implicit operator D3D12_RAYTRACING_PIPELINE_CONFIG(uint value) => new(value);
    
    readonly uint IValueGet<uint>.GetValue() => MaxTraceRecursionDepth;
    readonly object? IValueGet.GetValue() => MaxTraceRecursionDepth;
}
