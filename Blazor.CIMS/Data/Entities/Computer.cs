using System;
namespace Blazor.CIMS.Data
{
    public partial class Computer : GeneralDevice
    {
        public int UsbPort { get; set; }
        public int RamSlot { get; set; }
        public string FromFactor { get; set; }
    }
}
