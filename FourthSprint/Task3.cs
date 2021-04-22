using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    public enum ColourEnum
    {
        Red,
        Green,
        Blue
    }
    public interface IColoured
    {
        ColourEnum Colour
        {
            get
            {
                return ColourEnum.Red;
            }
        }
    }
    public interface IDocument
    {
        static string defaultText = "Lorem ipsum";
        public int Pages
        {
            get
            {
                return 0;
            }
            set
            {
                Pages = value;
            }
        }

        public string Name { get; set; }
        void AddPages(int a)
        {
            Pages += a;
        }
        void Rename(string name)
        {
            Name = name;
        }
    }
    class ColouredDocument : IDocument, IColoured
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public ColourEnum Colour { get; set; }
        public ColouredDocument(ColourEnum colour)
        {
            Colour = colour;
        }
        public ColouredDocument() { }
        public void Rename(string name)
        {
            Name = name;
        }
    }
    class Example
    {
        public static void Do()
        {
            ColouredDocument doc1 = new ColouredDocument();
            doc1.Name = "Document1";
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            Console.WriteLine(doc1.Name);

        }
    }
}
