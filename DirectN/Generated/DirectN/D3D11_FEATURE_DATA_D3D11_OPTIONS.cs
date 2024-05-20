#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options
[StructLayout(LayoutKind.Sequential)]
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
{
    [MarshalAs(UnmanagedType.U4)]
    public bool OutputMergerLogicOp;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool UAVOnlyRenderingForcedSampleCount;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool DiscardAPIsSeenByDriver;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool FlagsForUpdateAndCopySeenByDriver;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ClearView;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool CopyWithOverlap;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ConstantBufferPartialUpdate;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ConstantBufferOffsetting;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MapNoOverwriteOnDynamicConstantBuffer;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MapNoOverwriteOnDynamicBufferSRV;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool MultisampleRTVWithForcedSampleCountOne;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool SAD4ShaderInstructions;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ExtendedDoublesShaderInstructions;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool ExtendedResourceSharing;
}
