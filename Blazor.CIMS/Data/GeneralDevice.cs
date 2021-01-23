using System;
using Blazor.CIMS.Helpers;

namespace Blazor.CIMS.Data
{
    public class GeneralDevice : TrackingEntity
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public long Memory { get; set; }        
        public long Ram { get; set; }
        public int Types { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }
    }
}
