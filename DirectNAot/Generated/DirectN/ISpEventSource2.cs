namespace DirectN;

[GeneratedComInterface, Guid("2373a435-6a4b-429e-a6ac-d4231a61975b")]
public partial interface ISpEventSource2 : ISpEventSource
{
    [PreserveSig]
    [return: MarshalAs(UnmanagedType.Error)]
    HRESULT GetEventsEx(uint ulCount, ref SPEVENTEX pEventArray, ref uint pulFetched);
}
