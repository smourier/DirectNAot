namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_videotransfermatrix
public enum DXVA2_VideoTransferMatrix
{
    DXVA2_VideoTransferMatrixMask = 7,
    DXVA2_VideoTransferMatrix_Unknown = 0,
    DXVA2_VideoTransferMatrix_BT709 = 1,
    DXVA2_VideoTransferMatrix_BT601 = 2,
    DXVA2_VideoTransferMatrix_SMPTE240M = 3,
}
