namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d12/nn-d3d12-id3d12tools
[GeneratedComInterface, Guid("7071e1f0-e84b-4b33-974f-12fa49de65c5")]
public partial interface ID3D12Tools
{
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12tools-enableshaderinstrumentation
    [PreserveSig]
    void EnableShaderInstrumentation([MarshalAs(UnmanagedType.U4)] bool bEnable);
    
    // https://learn.microsoft.com/windows/win32/api/d3d12/nf-d3d12-id3d12tools-shaderinstrumentationenabled
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.U4)]
    bool ShaderInstrumentationEnabled();
}
