#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/winddi/ns-winddi-engsafesemaphore
public partial struct ENGSAFESEMAPHORE
{
    public HSEMAPHORE hsem;
    public int lCount;
}
