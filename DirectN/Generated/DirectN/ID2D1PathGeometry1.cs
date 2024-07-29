#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1_1/nn-d2d1_1-id2d1pathgeometry1
[SupportedOSPlatform("windows8.0")]
[GeneratedComInterface, Guid("62baa2d2-ab54-41b7-b872-787e0106a421")]
public partial interface ID2D1PathGeometry1 : ID2D1PathGeometry
{
    // https://learn.microsoft.com/windows/win32/api/d2d1_1/nf-d2d1_1-id2d1pathgeometry1-computepointandsegmentatlength(float_uint32_constd2d1_matrix_3x2_f__float_d2d1_point_description)
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT ComputePointAndSegmentAtLength(float length, uint startSegment, nint /* optional D2D_MATRIX_3X2_F* */ worldTransform, float flatteningTolerance, out D2D1_POINT_DESCRIPTION pointDescription);
}
