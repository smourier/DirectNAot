#nullable enable
namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/windows.ui.xaml.hosting.referencetracker/nn-windows-ui-xaml-hosting-referencetracker-ifindreferencetargetscallback
[GeneratedComInterface, Guid("04b3486c-4687-4229-8d14-505ab584dd88")]
public partial interface IFindReferenceTargetsCallback
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT FoundTrackerTarget([MarshalUsing(typeof(UniqueComInterfaceMarshaller<IReferenceTrackerTarget>))] IReferenceTrackerTarget target);
}
