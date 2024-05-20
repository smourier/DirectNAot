#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("12e3cca9-7518-44c5-a5e7-ba5a79cb929e")]
public partial interface ISpStream : ISpStreamFormat
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT SetBaseStream(IStream pStream, in Guid rguidFormat, in WAVEFORMATEX pWaveFormatEx);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetBaseStream(out IStream ppStream);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT BindToFile(PWSTR pszFileName, SPFILEMODE eMode, nint /* optional Guid* */ pFormatId, nint /* optional WAVEFORMATEX* */ pWaveFormatEx, ulong ullEventInterest);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Close();
}
