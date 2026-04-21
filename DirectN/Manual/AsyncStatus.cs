namespace DirectN;

public enum AsyncStatus
{
    Started = 0,
    Completed = (Started + 1),
    Canceled = (Completed + 1),
    Error = (Canceled + 1)
}
