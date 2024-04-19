namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9procampcontrolflags
public enum VMR9ProcAmpControlFlags
{
    ProcAmpControl9_Brightness = 1,
    ProcAmpControl9_Contrast = 2,
    ProcAmpControl9_Hue = 4,
    ProcAmpControl9_Saturation = 8,
    ProcAmpControl9_Mask = 15,
}
