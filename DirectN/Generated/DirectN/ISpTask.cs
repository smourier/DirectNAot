#nullable enable
namespace DirectN;

public partial struct ISpTask
{
    public nint VTablePtr;
    
    [return: MarshalAs(UnmanagedType.Error)]
    public unsafe HRESULT Execute(nint pvTaskData, in int pfContinueProcessing)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpTask*,nint,int, HRESULT>)(((void**)VTablePtr)[0]))((ISpTask*)VTablePtr, pvTaskData, pfContinueProcessing);
    }
}
