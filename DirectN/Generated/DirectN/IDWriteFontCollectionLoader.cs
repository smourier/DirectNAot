﻿#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/dwrite/nn-dwrite-idwritefontcollectionloader
[SupportedOSPlatform("windows6.1")]
[GeneratedComInterface, Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468")]
public partial interface IDWriteFontCollectionLoader
{
    // https://learn.microsoft.com/windows/win32/api/dwrite/nf-dwrite-idwritefontcollectionloader-createenumeratorfromkey
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT CreateEnumeratorFromKey([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFactory>))] IDWriteFactory factory, nint collectionKey, uint collectionKeySize, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDWriteFontFileEnumerator>))] out IDWriteFontFileEnumerator fontFileEnumerator);
}
