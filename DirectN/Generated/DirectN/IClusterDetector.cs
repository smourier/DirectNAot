﻿#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("3f07f7b7-c680-41d9-9423-915107ec9ff9")]
public partial interface IClusterDetector
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Initialize(ushort wBaseEntryLevel, ushort wClusterEntryLevel);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT Detect(uint dwMaxNumClusters, float fMinClusterDuration, float fMaxClusterDuration, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IToc>))] IToc pSrcToc, [MarshalUsing(typeof(UniqueComInterfaceMarshaller<IToc>))] out IToc ppDstToc);
}
