namespace DirectN;

[StructLayout(LayoutKind.Sequential)]
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS14
{
    [MarshalAs(UnmanagedType.U4)]
    public bool AdvancedTextureOpsSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool WriteableMSAATexturesSupported;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool IndependentFrontAndBackStencilRefMaskSupported;
}
