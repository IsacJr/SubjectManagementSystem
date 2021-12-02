using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SubjectManagementSystem.Domain
{    public static class EnumExtensions
    {
        public static List<EnumValue> GetValues<T>()
        {
            List<EnumValue> values = new List<EnumValue>();
            foreach (var itemType in Enum.GetValues(typeof(T)))
            {
                //For each value of this enumeration, add a new EnumValue instance
                values.Add(new EnumValue()
                {
                    Name = GetDescription((Enum)itemType),//Enum.GetName(typeof(T), itemType), 
                    Value = (int)itemType
                });
            }
            return values;
        }

        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                    .GetMember(enumValue.ToString())
                    .First()
                    .GetCustomAttribute<DescriptionAttribute>()?
                    .Description ?? string.Empty;
        }
    }

}