using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Utils
{
    public static class Utils
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
        public static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            DataTable dt = new DataTable();
            foreach (object obj in varlist)
            {
                Type t = obj.GetType();
                PropertyInfo[] pis = t.GetProperties();
                if (dt.Columns.Count == 0)
                {
                    foreach (PropertyInfo pi in pis)
                    {
                        Type pt = pi.PropertyType;
                        if (pt.IsGenericType && pt.GetGenericTypeDefinition() == typeof(Nullable<>))
                            pt = Nullable.GetUnderlyingType(pt);
                        dt.Columns.Add(pi.Name, pt);
                    }
                }
                DataRow dr = dt.NewRow();
                foreach (PropertyInfo pi in pis)
                {
                    object value = pi.GetValue(obj, null);
                    dr[pi.Name] = value ?? DBNull.Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}