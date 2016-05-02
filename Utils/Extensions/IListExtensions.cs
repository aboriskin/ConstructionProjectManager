using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Extensions
{
    public static class IListExtensions
    {
        public static bool IsNullOrEmpty(this IList list)
        {
            return list == null || list.Count == 0;
        }

        public static bool SafeContains<T>(this IList<T> list, T item)
        {
            if (list == null)
            {
                return false;
            }
            return list.Contains(item);
        }

        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            var result = new List<T>();

            var array = new T[list.Count];
            list.CopyTo(array, arrayIndex: 0);
            var copiedList = array.ToList();

            while (copiedList.Count > 0)
            {
                var randInd = RandomHelper.GetRandomNumber(0, copiedList.Count - 1);
                result.Add(copiedList[randInd]);
                copiedList.RemoveAt(randInd);
            }

            return result;
        }
    }
}
