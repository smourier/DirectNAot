﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("a74d7c8e-4cc5-4f2f-a6eb-804dee18500e")]
public partial interface ISpTTSEngine
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Speak(uint dwSpeakFlags, in Guid rguidFormatId, in WAVEFORMATEX pWaveFormatEx, in SPVTEXTFRAG pTextFragList, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<ISpTTSEngineSite>))] ISpTTSEngineSite pOutputSite);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetOutputFormat(in Guid pTargetFmtId, in WAVEFORMATEX pTargetWaveFormatEx, out Guid pOutputFormatId, out nint ppCoMemOutputWaveFormatEx);
}
