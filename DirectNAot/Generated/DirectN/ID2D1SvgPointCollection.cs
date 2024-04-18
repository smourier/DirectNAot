namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/d2d1svg/nn-d2d1svg-id2d1svgpointcollection
[GeneratedComInterface, Guid("9dbe4c0d-3572-4dd9-9825-5530813bb712")]
public partial interface ID2D1SvgPointCollection : ID2D1SvgAttribute
{
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpointcollection-removepointsatend
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT RemovePointsAtEnd(uint pointsCount);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpointcollection-updatepoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT UpdatePoints(in D2D_POINT_2F points, uint pointsCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpointcollection-getpoints
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    public HRESULT GetPoints(out D2D_POINT_2F points, uint pointsCount, uint startIndex);
    
    // https://learn.microsoft.com/windows/win32/api/d2d1svg/nf-d2d1svg-id2d1svgpointcollection-getpointscount
    [PreserveSig]
    public uint GetPointsCount();
}
