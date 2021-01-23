using System;
using Blazor.CIMS.Helpers;

namespace Blazor.CIMS.Data
{
    public class GeneralDevice : TrackingEntity
    {
        public Guid Id { get; set; }
        public string Brand { get; set; }
        public string Processor { get; set; }
        public string Memory { get; set; }        
        public string Ram { get; set; }
        public int Types { get; set; }
        public int Quantity { get; set; }
        public Decimal Price { get; set; }

        public string DisplayTypes()
        {
            return ((DeviceTypes)Types).ToString();
        }
    }
}
