﻿namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wingdi/ns-wingdi-displayconfig_desktop_image_info
[StructLayout(LayoutKind.Sequential)]
public partial struct DISPLAYCONFIG_DESKTOP_IMAGE_INFO
{
    public POINTL PathSourceSize;
    public RECTL DesktopImageRegion;
    public RECTL DesktopImageClip;
}
