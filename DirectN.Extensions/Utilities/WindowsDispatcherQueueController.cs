using System.Runtime.InteropServices.Marshalling;
using DirectN.Com;

namespace DirectN.Extensions.Utilities;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial class WindowsDispatcherQueueController : InterlockedComReference
{
    public WindowsDispatcherQueueController()
        : base(0)
    {
    }

    public unsafe void EnsureOnCurrentThread()
    {
        using var statics = Com.ComObject.GetActivationFactory<IDispatcherQueueStatics>("Windows.System.DispatcherQueue")!;
        statics.Object.GetForCurrentThread(out var queue).ThrowOnError();
        if (queue != null || RawReference != 0)
        {
            queue.FinalRelease();
            return;
        }
        queue.FinalRelease();

        var options = new DispatcherQueueOptions
        {
            dwSize = (uint)sizeof(DispatcherQueueOptions),
            threadType = DISPATCHERQUEUE_THREAD_TYPE.DQTYPE_THREAD_CURRENT,
            apartmentType = DISPATCHERQUEUE_THREAD_APARTMENTTYPE.DQTAT_COM_STA,
        };

        Functions.CreateDispatcherQueueController(options, out var controller).ThrowOnError();
        ExchangeReference(controller);
    }

    public void Shutdown()
    {
        var controllerRef = RawReference;
        if (controllerRef == 0)
            return;

        using var controller = Com.ComObject.FromPointer<IDispatcherQueueController>(controllerRef);
        if (controller != null)
        {
            controller.Object.get_ShutdownQueueAsync(out var action).ThrowOnError();
            action.GetResults().ThrowOnError();
        }
        Dispose();
    }

    [GeneratedComInterface, Guid("a96d83d7-9371-4517-9245-d0824ac12c74")]
    internal partial interface IDispatcherQueueStatics : IInspectableLocal
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT GetForCurrentThread([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IDispatcherQueue>))] out IDispatcherQueue value);
    }

    [GeneratedComInterface, Guid("603e88e4-a338-4ffe-a457-a5cfb9ceb899")]
    internal partial interface IDispatcherQueue : IInspectableLocal
    {
        // defs not needed
    }

    [GeneratedComInterface, Guid("22f34e66-50db-4e36-a98d-61c01b384d20")]
    internal partial interface IDispatcherQueueController : IInspectableLocal
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT get_DispatcherQueue(out /* Windows::System::IDispatcherQueue */ nint value);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT get_ShutdownQueueAsync([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IAsyncAction>))] out IAsyncAction operation);
    }

    [GeneratedComInterface, Guid("5a648006-843a-4da9-865b-9d26e5dfad7b")]
    internal partial interface IAsyncAction : IInspectableLocal
    {
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT put_Completed(out /* Windows::Foundation::IAsyncActionCompletedHandler */ nint handler);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT get_Completed(/* Windows::Foundation::IAsyncActionCompletedHandler */ out nint operation);

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Error)]
        HRESULT GetResults();
    }
}
