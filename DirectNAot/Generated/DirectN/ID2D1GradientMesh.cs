#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_3/nn-d2d1_3-id2d1gradientmesh
[SupportedOSPlatform("windows8.1")]
[GeneratedComInterface, Guid("f292e401-c050-4cde-83d7-04962d3b23c2")]
public partial interface ID2D1GradientMesh : ID2D1Resource
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1gradientmesh-getpatchcount
    [PreserveSig]
    uint GetPatchCount();
    
    // https://learn.microsoft.com/windows/win32/api/d2d1_3/nf-d2d1_3-id2d1gradientmesh-getpatches
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPatches(uint startIndex, [MarshalUsing(CountElementName = nameof(patchesCount))] ref D2D1_GRADIENT_MESH_PATCH[] patches, uint patchesCount);
}
