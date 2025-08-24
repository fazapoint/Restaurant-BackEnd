using System.ComponentModel;

namespace Restaurant.BackEnd.Service.Common.Contracts
{
    public enum OrderStatus
    {
        Open,
        Pending,
        InProgress,
        Completed,
        Cancelled
    }
}
