using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndPoint = $"{Prefix}/makes";
        public static readonly string ModelsEndPoint = $"{Prefix}/models";
        public static readonly string ColoursEndPoint = $"{Prefix}/colours";
        public static readonly string VehiclesEndPoint = $"{Prefix}/vehicles";
        public static readonly string CustomersEndPoint = $"{Prefix}/customers";
        public static readonly string BookingsEndPoint = $"{Prefix}/bookings";

    }
}
