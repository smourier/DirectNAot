namespace DirectN;

[GeneratedComInterface, Guid("bed530be-2606-4f4d-a1c0-54c5cda5566f")]
public partial interface ISpStreamFormat : IStream
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetFormat(in Guid pguidFormatId, out nint ppCoMemWaveFormatEx);
}
