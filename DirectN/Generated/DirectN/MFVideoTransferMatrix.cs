#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideotransfermatrix
public enum MFVideoTransferMatrix
{
    MFVideoTransferMatrix_Unknown = 0,
    MFVideoTransferMatrix_BT709 = 1,
    MFVideoTransferMatrix_BT601 = 2,
    MFVideoTransferMatrix_SMPTE240M = 3,
    MFVideoTransferMatrix_BT2020_10 = 4,
    MFVideoTransferMatrix_BT2020_12 = 5,
    MFVideoTransferMatrix_Last = 6,
    MFVideoTransferMatrix_ForceDWORD = int.MaxValue,
}
