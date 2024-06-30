#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d3d11/ns-d3d11-d3d11_feature_data_d3d11_options
public partial struct D3D11_FEATURE_DATA_D3D11_OPTIONS
{
    public BOOL OutputMergerLogicOp;
    public BOOL UAVOnlyRenderingForcedSampleCount;
    public BOOL DiscardAPIsSeenByDriver;
    public BOOL FlagsForUpdateAndCopySeenByDriver;
    public BOOL ClearView;
    public BOOL CopyWithOverlap;
    public BOOL ConstantBufferPartialUpdate;
    public BOOL ConstantBufferOffsetting;
    public BOOL MapNoOverwriteOnDynamicConstantBuffer;
    public BOOL MapNoOverwriteOnDynamicBufferSRV;
    public BOOL MultisampleRTVWithForcedSampleCountOne;
    public BOOL SAD4ShaderInstructions;
    public BOOL ExtendedDoublesShaderInstructions;
    public BOOL ExtendedResourceSharing;
}
