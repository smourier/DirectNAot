namespace DirectN.Samples.PdfView;

public class CompositionApplication : Application
{
    public CompositionApplication()
    {
        // no, we can't use Windows.System.DispatcherQueueController.CreateOnDedicatedThread();
        // or compositor will raise an access denied error
        DispatcherQueueController = new WindowsDispatcherQueueController();
        DispatcherQueueController.EnsureOnCurrentThread();
    }

    public WindowsDispatcherQueueController DispatcherQueueController { get; }
}
