using Restaurant.BackEnd.Service.Common.Contracts;
using Restaurant.BackEnd.Service.Common.Templates;

namespace Restaurant.BackEnd.Service.Common.Models.Entities
{
    public class Table : EntityBase
    {
        public string Number { get; set; }
        public TableType TableType { get; set; }
        public int Capacity { get; set; }
        public TableStatus TableStatus { get; set; }
    }
}