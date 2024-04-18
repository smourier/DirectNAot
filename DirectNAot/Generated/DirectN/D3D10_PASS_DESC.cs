namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d10effect/ns-d3d10effect-d3d10_pass_desc
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D10_PASS_DESC
{
    public PSTR Name;
    public uint Annotations;
    public nint pIAInputSignature;
    public nuint IAInputSignatureSize;
    public uint StencilRef;
    public uint SampleMask;
    public InlineArraySingle4 BlendFactor;
}
