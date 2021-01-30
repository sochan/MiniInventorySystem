using System;
namespace Blazor.CIMS.Data
{
    public class TrackingEntity
    {
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        
    }
}
