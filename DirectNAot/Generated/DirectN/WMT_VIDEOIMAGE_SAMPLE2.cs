#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/wmsdkidl/ns-wmsdkidl-wmt_videoimage_sample2
[StructLayout(LayoutKind.Sequential)]
public partial struct WMT_VIDEOIMAGE_SAMPLE2
{
    public uint dwMagic;
    public uint dwStructSize;
    public uint dwControlFlags;
    public uint dwViewportWidth;
    public uint dwViewportHeight;
    public uint dwCurrImageWidth;
    public uint dwCurrImageHeight;
    public float fCurrRegionX0;
    public float fCurrRegionY0;
    public float fCurrRegionWidth;
    public float fCurrRegionHeight;
    public float fCurrBlendCoef;
    public uint dwPrevImageWidth;
    public uint dwPrevImageHeight;
    public float fPrevRegionX0;
    public float fPrevRegionY0;
    public float fPrevRegionWidth;
    public float fPrevRegionHeight;
    public float fPrevBlendCoef;
    public uint dwEffectType;
    public uint dwNumEffectParas;
    public float fEffectPara0;
    public float fEffectPara1;
    public float fEffectPara2;
    public float fEffectPara3;
    public float fEffectPara4;
    
    [MarshalAs(UnmanagedType.U4)]
    public bool bKeepPrevImage;
}
