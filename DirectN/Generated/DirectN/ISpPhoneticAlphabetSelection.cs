#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("b2745efd-42ce-48ca-81f1-a96e02538a90")]
public partial interface ISpPhoneticAlphabetSelection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT IsAlphabetUPS([MarshalAs(UnmanagedType.U4)] out bool pfIsUPS);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetAlphabetToUPS([MarshalAs(UnmanagedType.U4)] bool fForceUPS);
}
