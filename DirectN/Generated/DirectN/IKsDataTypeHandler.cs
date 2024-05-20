﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("5ffbaa02-49a3-11d0-9f36-00aa00a216a1")]
public partial interface IKsDataTypeHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsCompleteIoOperation(IMediaSample Sample, nint StreamHeader, KSIOOPERATION IoOperation, [MarshalAs(UnmanagedType.U4)] bool Cancelled);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsIsMediaTypeInRanges(nint DataRanges);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsPrepareIoOperation(IMediaSample Sample, nint StreamHeader, KSIOOPERATION IoOperation);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsQueryExtendedSize(out uint ExtendedSize);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetMediaType(in AM_MEDIA_TYPE AmMediaType);
}
