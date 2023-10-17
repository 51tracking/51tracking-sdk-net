using System;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace Tracking51API.Util;

public class StringUtil
{
    public static string ObjectToQueryString(object obj)
    {
        var properties = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var queryString = new StringBuilder();

        foreach (var prop in properties)
        {
            var jsonPropertyAttribute = prop.GetCustomAttribute<JsonPropertyAttribute>();
            if (jsonPropertyAttribute != null)
            {
                var value = prop.GetValue(obj);
                if (value != null)
                {

                var defaultValue = GetDefault(prop.PropertyType);
                if (!value.Equals(defaultValue))
                {
                        if (queryString.Length > 0)
                        {
                            queryString.Append("&");
                        }
                        queryString.AppendFormat("{0}={1}", Uri.EscapeDataString(jsonPropertyAttribute.PropertyName), Uri.EscapeDataString(value.ToString()));
                }

                }
            }
        }

        return queryString.ToString();
    }

    private static object GetDefault(Type type)
    {
        if (type.IsValueType)
        {
            return Activator.CreateInstance(type);
        }
        return null;
    }
}