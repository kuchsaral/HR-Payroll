using APICorePayroll.Data_Repository;
using System.Collections.Generic;
using System.Linq;

namespace APICorePayroll
{
    public static class ExtensionClass
    {
        public static T Clone<T>(this T source) where T : ICloneEntity
        {
            return (T)(source.MemberwiseClone());
        }

        public static IEnumerable<T> SelectClone<T>(this IEnumerable<T> sources) where T : PayrollEntityBase
        {
            return sources.Select(line => line.Clone());
        }
        /// <summary>
        /// Putting T source into IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<T> Muoy<T>(this T source)
        {
            return Enumerable.Repeat<T>(source, 1);
        }
    }
}