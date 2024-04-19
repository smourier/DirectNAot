namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/codecapi/ne-codecapi-eavencvideocolortransfermatrix
public enum eAVEncVideoColorTransferMatrix
{
    eAVEncVideoColorTransferMatrix_SameAsSource = 0,
    eAVEncVideoColorTransferMatrix_BT709 = 1,
    eAVEncVideoColorTransferMatrix_BT601 = 2,
    eAVEncVideoColorTransferMatrix_SMPTE240M = 3,
}
