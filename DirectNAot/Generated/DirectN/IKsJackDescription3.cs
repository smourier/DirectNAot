namespace DirectN;

[GeneratedComInterface, Guid("e3f6778b-6660-4cc8-a291-ecc4192d9967")]
public partial interface IKsJackDescription3
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackCount(out uint pcJacks);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetJackDescription3(uint nJack, out KSJACK_DESCRIPTION3 pDescription3);
}
