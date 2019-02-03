using FT.Common.Types;
using System;

namespace FT.Services.Tickets.Domain
{
    public class Plain : IIdentifiable
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string IsoCode { get; protected set; }
        public ushort NumberOfSeats { get; protected set; }
        public bool Deleted { get; protected set; }
    }
}
