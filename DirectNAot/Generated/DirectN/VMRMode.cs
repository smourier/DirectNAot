namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/strmif/ne-strmif-vmrmode
public enum VMRMode
{
    VMRMode_Windowed = 1,
    VMRMode_Windowless = 2,
    VMRMode_Renderless = 4,
    VMRMode_Mask = 7,
}
