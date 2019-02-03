using FT.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FT.Services.Tickets.Domain
{
    public class AirLine : IIdentifiable
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public bool Deleted { get; protected set; }
    }
}
