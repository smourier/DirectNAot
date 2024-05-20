#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/vmr9/ne-vmr9-vmr9mode
public enum VMR9Mode
{
    VMR9Mode_Windowed = 1,
    VMR9Mode_Windowless = 2,
    VMR9Mode_Renderless = 4,
    VMR9Mode_Mask = 7,
}
