#nullable enable
namespace DirectN;

public partial struct AudioClient3ActivationParams : IValueGet<Guid>
{
    public Guid tracingContextId;
    
    readonly Guid IValueGet<Guid>.GetValue() => tracingContextId;
    readonly object? IValueGet.GetValue() => tracingContextId;
}
