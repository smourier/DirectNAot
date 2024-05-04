#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d2ac287c-b39b-11d1-8704-00600893b1bd")]
public partial interface IDirectMusicCollection
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetInstrument(uint dwPatch, out IDirectMusicInstrument ppInstrument);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT EnumInstrument(uint dwIndex, ref uint pdwPatch, PWSTR pwszName, uint dwNameLen);
}
