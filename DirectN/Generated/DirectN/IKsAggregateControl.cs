#nullable enable
namespace DirectN;

[GeneratedComInterface, Guid("7f40eac0-3947-11d2-874e-00a0c9223196")]
public partial interface IKsAggregateControl
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsAddAggregate(in Guid AggregateClass);
    
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT KsRemoveAggregate(in Guid AggregateClass);
}
