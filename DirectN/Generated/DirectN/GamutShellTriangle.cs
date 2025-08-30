#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wcsplugin/ns-wcsplugin-gamutshelltriangle
public partial struct GamutShellTriangle : IValueGet<uint[]>
{
    public InlineArrayUInt32_3 aVertexIndex;
    
    readonly uint[]? IValueGet<uint[]>.GetValue() => ((ReadOnlySpan<uint>)aVertexIndex).ToArray();
    readonly object? IValueGet.GetValue() => ((ReadOnlySpan<uint>)aVertexIndex).ToArray();
}
