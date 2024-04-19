namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfobjects/ne-mfobjects-mfvideoflags
public enum MFVideoFlags
{
    MFVideoFlag_PAD_TO_Mask = 3,
    MFVideoFlag_PAD_TO_None = 0,
    MFVideoFlag_PAD_TO_4x3 = 1,
    MFVideoFlag_PAD_TO_16x9 = 2,
    MFVideoFlag_SrcContentHintMask = 28,
    MFVideoFlag_SrcContentHintNone = 0,
    MFVideoFlag_SrcContentHint16x9 = 4,
    MFVideoFlag_SrcContentHint235_1 = 8,
    MFVideoFlag_AnalogProtected = 32,
    MFVideoFlag_DigitallyProtected = 64,
    MFVideoFlag_ProgressiveContent = 128,
    MFVideoFlag_FieldRepeatCountMask = 1792,
    MFVideoFlag_FieldRepeatCountShift = 8,
    MFVideoFlag_ProgressiveSeqReset = 2048,
    MFVideoFlag_PanScanEnabled = 131072,
    MFVideoFlag_LowerFieldFirst = 262144,
    MFVideoFlag_BottomUpLinearRep = 524288,
    MFVideoFlags_DXVASurface = 1048576,
    MFVideoFlags_RenderTargetSurface = 4194304,
    MFVideoFlags_ForceQWORD = int.MaxValue,
}
