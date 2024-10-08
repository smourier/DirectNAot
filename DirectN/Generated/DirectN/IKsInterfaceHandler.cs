﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("d3abc7e0-9a61-11d0-a40d-00a0c9223196")]
public partial interface IKsInterfaceHandler
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsSetPin([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKsPin>))] IKsPin KsPin);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsProcessMediaSamples([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IKsDataTypeHandler>))] IKsDataTypeHandler KsDataTypeHandler, [In][MarshalUsing(CountElementName = nameof(SampleCount))] IMediaSample[] SampleList, ref int SampleCount, KSIOOPERATION IoOperation, out nint StreamSegment);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsCompleteIo(ref KSSTREAM_SEGMENT StreamSegment);
}
