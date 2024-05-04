#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/direct3dhlsl/dx-graphics-hlsl-matrix
[StructLayout(LayoutKind.Sequential)]
public partial struct Matrix
{
    public static readonly Matrix Null = new();
    
    public nint Value;
}
