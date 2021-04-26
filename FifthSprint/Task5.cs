using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{

    class EventProgram
    {
        public static Lookup<string, string> CreateNotebook(Dictionary<string, string> phonesToNames)
        {
            for (int i = 0; i < phonesToNames.Count; i++)
            {
                if (phonesToNames.ElementAt(i).Value == null) phonesToNames[phonesToNames.ElementAt(i).Key] = "";
            }
            List<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string, string>>();
            foreach (var key in phonesToNames)
            {
                pairs.Add(new KeyValuePair<string, string>(key.Value, key.Key));
            }
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < pairs.Count; i++)
            {
                var t = pairs[i].Key;
                List<string> numbers = new List<string>();
                for (int j = i; j < pairs.Count; j++)
                {
                    if (t == pairs[j].Key) numbers.Add(pairs[j].Value);
                }
                dict.TryAdd(t, numbers);
            }
            return (Lookup<string, string>)dict.SelectMany(p => p.Value
                                         .Select(x => new { p.Key, Value = x }))
                       .ToLookup(pair => pair.Key, pair => pair.Value);
        }
    }
}
