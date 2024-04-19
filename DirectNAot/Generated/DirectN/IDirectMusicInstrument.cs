namespace DirectN;

[GeneratedComInterface, Guid("d2ac287d-b39b-11d1-8704-00600893b1bd")]
public partial interface IDirectMusicInstrument
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetPatch(ref uint pdwPatch);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetPatch(uint dwPatch);
}
