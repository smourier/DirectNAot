﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfmediaengine/ne-mfmediaengine-mf_media_engine_err
public enum MF_MEDIA_ENGINE_ERR
{
    MF_MEDIA_ENGINE_ERR_NOERROR = 0,
    MF_MEDIA_ENGINE_ERR_ABORTED = 1,
    MF_MEDIA_ENGINE_ERR_NETWORK = 2,
    MF_MEDIA_ENGINE_ERR_DECODE = 3,
    MF_MEDIA_ENGINE_ERR_SRC_NOT_SUPPORTED = 4,
    MF_MEDIA_ENGINE_ERR_ENCRYPTED = 5,
}
