namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9presentationflags
public enum VMR9PresentationFlags
{
    VMR9Sample_SyncPoint = 1,
    VMR9Sample_Preroll = 2,
    VMR9Sample_Discontinuity = 4,
    VMR9Sample_TimeValid = 8,
    VMR9Sample_SrcDstRectsValid = 16,
}
