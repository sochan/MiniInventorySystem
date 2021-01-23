using System;
using System.Collections.Generic;
using System.Linq;
using Blazor.CIMS.Data;

namespace Blazor.CIMS.Helpers
{
    public static class Util
    {
        // All device types
        public static IList<DeviceType> ListTypes()
        {
            List<DeviceType> enums = ((DeviceTypes[])Enum.GetValues(typeof(DeviceTypes))).Select(c => new DeviceType() { Value = (int)c, Name = c.ToString() }).ToList();
            return enums;
        }

        public static DeviceTypes EnumTypes(int types)
        {
            return (DeviceTypes)types;
        }

        public static DeviceTypes AllTypes(this GeneralDevice device)
        {
            return EnumTypes(device.Types);
        }

        public static bool IsHavingType(int types, DeviceTypes type)
        {
            bool isType = ((DeviceTypes)types & type) == type;
            return isType;
        }

        #region
        // Extension methods to get sum of list of string numbers
        public static string DateDisplay(this DateTime? dt)
        {
            return dt != null ? dt.Value.ToString("dd/MM/yyyy") : "n/a";
        }

        public static string DisplayStatus(this bool? isActive)
        {
            return (isActive.Value ? "Active" : "Inactive");
        }

        public static int Sum(this List<string> types)
        {
            var sum = 0;
            foreach (var type in types)
            {
                sum += int.Parse(type);
            }
            return sum;
        }

        // Types into List<string>
        public static List<string> ListStrTypes(this int types)
        {
            List<string> list = new List<string>();
            var enumTypes = (DeviceTypes)types;

            if ((enumTypes & DeviceTypes.Laptop) == DeviceTypes.Laptop)
                list.Add(((int)DeviceTypes.Laptop).ToString());

            if ((enumTypes & DeviceTypes.Desktop) == DeviceTypes.Desktop)
                list.Add(((int)DeviceTypes.Desktop).ToString());

            if ((enumTypes & DeviceTypes.Tablet) == DeviceTypes.Tablet)
                list.Add(((int)DeviceTypes.Tablet).ToString());

            if ((enumTypes & DeviceTypes.Server) == DeviceTypes.Server)
                list.Add(((int)DeviceTypes.Server).ToString());

            if ((enumTypes & DeviceTypes.Smartphone) == DeviceTypes.Smartphone)
                list.Add(((int)DeviceTypes.Smartphone).ToString());

            if ((enumTypes & DeviceTypes.Game) == DeviceTypes.Game)
                list.Add(((int)DeviceTypes.Game).ToString());

            return list;
        }


        public static string CurrencyDisplay(this Decimal price)
        {
            return price.ToString("C");
        }
        #endregion


    }
}
