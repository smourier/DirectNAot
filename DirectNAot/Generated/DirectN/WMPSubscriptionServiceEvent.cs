namespace DirectN;

// https://learn.microsoft.com/windows/win32/api/subscriptionservices/ne-subscriptionservices-wmpsubscriptionserviceevent
public enum WMPSubscriptionServiceEvent
{
    wmpsseCurrentBegin = 1,
    wmpsseCurrentEnd = 2,
    wmpsseFullBegin = 3,
    wmpsseFullEnd = 4,
}
