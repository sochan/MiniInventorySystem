using System;
namespace Blazor.CIMS.Helpers
{
    [Flags]
    public enum DeviceTypes
    {
        //None = 0b_0000_0000,  // 0
        Laptop = 0b_0000_0001,  // 1
        Desktop = 0b_0000_0010,  // 2
        Server = 0b_0000_0100,  // 4
        Tablet = 0b_0000_1000,  // 8
        Smartphone = 0b_0001_0000,  // 16
        Game = 0b_0010_0000,  // 32
    }

    public class DeviceType
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
