using System.Collections;
using System.Collections.Generic;

 public class CircleOfChildren
    {
        public IEnumerable<string> Children { get; set; }
        public CircleOfChildren(IEnumerable<string> children)
        {
            Children = children;
        }
        public IEnumerable GetChildrenInOrder(int syllables, int children)
        {
            List<string> list = (List<string>)Children;
            if (list.Count < children) children = list.Count;
            if (syllables <= 0) children = 0;
            int t = 0;
            for(int i = 0; i < children; i++)
            {                
                int a = (syllables - 1 + t) % list.Count;                
                yield return list[a];
                list.RemoveAt(a);
                t = a;
            }            
        }

        public IEnumerable GetChildrenInOrder(int syllables)
        {
            List<string> list = (List<string>)Children;
            if (syllables <= 0) list = new List<string>();
            int t = 0;
            while(list.Count != 0)
            {
                int a = (syllables - 1 + t) % list.Count;
                yield return list[a];
                list.RemoveAt(a);
                t = a;
            }           
        }
    }
    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren circleOfChildren, int syllables, int children)
        {
            string s = "";
            foreach (var child in circleOfChildren.GetChildrenInOrder(syllables, children))  
                s += child + " ";          
            Console.WriteLine(s.Trim());
        }
    }
