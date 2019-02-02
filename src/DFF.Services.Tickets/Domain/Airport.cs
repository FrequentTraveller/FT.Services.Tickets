using DFF.Common.Types;
using System;

namespace DFF.Services.Tickets.Domain
{
    public class Airport : IIdentifiable
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Country { get; protected set; }
        public string City { get; protected set; }
        public double Longitude { get; protected set; }
        public double Latitude { get; protected set; }
        public bool Deleted { get; protected set; }
    }
}
