#nullable enable
namespace DirectN;

public partial struct ISpTask
{
    public static readonly ISpTask Null = new();
    
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public readonly unsafe HRESULT Execute(nint pvTaskData, in int pfContinueProcessing) =>
        ((delegate* unmanaged<ISpTask*,nint,int, HRESULT>)(((void**)*((void**)VTablePtr))[0]))((ISpTask*)VTablePtr, pvTaskData, pfContinueProcessing);
}
