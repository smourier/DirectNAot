#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/bdaiface/nn-bdaiface-ibda_autodemodulate
[GeneratedComInterface, Guid("ddf15b12-bd25-11d2-9ca0-00c04f7971e0")]
public partial interface IBDA_AutoDemodulate
{
    // https://learn.microsoft.com/windows/win32/api/bdaiface/nf-bdaiface-ibda_autodemodulate-put_autodemodulate
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT put_AutoDemodulate();
}
