namespace DirectN;

public enum DXVA_VideoTransferMatrix
{
    DXVA_VideoTransferMatrixShift = 15,
    DXVA_VideoTransferMatrixMask = 229376,
    DXVA_VideoTransferMatrix_Unknown = 0,
    DXVA_VideoTransferMatrix_BT709 = 1,
    DXVA_VideoTransferMatrix_BT601 = 2,
    DXVA_VideoTransferMatrix_SMPTE240M = 3,
}
