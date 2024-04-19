namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/mfsharingengine/ne-mfsharingengine-playto_source_createflags
public enum PLAYTO_SOURCE_CREATEFLAGS
{
    PLAYTO_SOURCE_NONE = 0,
    PLAYTO_SOURCE_IMAGE = 1,
    PLAYTO_SOURCE_AUDIO = 2,
    PLAYTO_SOURCE_VIDEO = 4,
    PLAYTO_SOURCE_PROTECTED = 8,
}
