using System.ComponentModel; // to create description that can be more human readable in UI

namespace Restaurant.BackEnd.Service.Common.Contracts
{
    public enum BillingStatus
    {
        Open,
        WaitingBilling,
        Paid
    }
}
