namespace DirectN;

public enum KS_VideoControlFlags
{
    KS_VideoControlFlag_FlipHorizontal = 1,
    KS_VideoControlFlag_FlipVertical = 2,
    KS_Obsolete_VideoControlFlag_ExternalTriggerEnable = 16,
    KS_Obsolete_VideoControlFlag_Trigger = 32,
    KS_VideoControlFlag_ExternalTriggerEnable = 4,
    KS_VideoControlFlag_Trigger = 8,
    KS_VideoControlFlag_IndependentImagePin = 64,
    KS_VideoControlFlag_StillCapturePreviewFrame = 128,
    KS_VideoControlFlag_StartPhotoSequenceCapture = 256,
    KS_VideoControlFlag_StopPhotoSequenceCapture = 512,
}
