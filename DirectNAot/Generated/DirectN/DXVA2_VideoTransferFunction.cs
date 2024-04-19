namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dxva2api/ne-dxva2api-dxva2_videotransferfunction
public enum DXVA2_VideoTransferFunction
{
    DXVA2_VideoTransFuncMask = 31,
    DXVA2_VideoTransFunc_Unknown = 0,
    DXVA2_VideoTransFunc_10 = 1,
    DXVA2_VideoTransFunc_18 = 2,
    DXVA2_VideoTransFunc_20 = 3,
    DXVA2_VideoTransFunc_22 = 4,
    DXVA2_VideoTransFunc_709 = 5,
    DXVA2_VideoTransFunc_240M = 6,
    DXVA2_VideoTransFunc_sRGB = 7,
    DXVA2_VideoTransFunc_28 = 8,
}
