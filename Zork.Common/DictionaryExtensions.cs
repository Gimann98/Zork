using System.Collections.Generic;

namespace Zork.Common
{
    public static class DictionaryExtensions
    {
        public static TValue GetValueOrDefaultKey<Tkey, TValue>(this IDictionary<Tkey, TValue> dictionary, Tkey key, TValue defaultValue = default(TValue))
        {
            return (dictionary != null && key != null && dictionary.TryGetValue(key, out TValue value)) ? value : defaultValue;
        }
    }
}
