using System.Xml.Linq;

namespace Engine.Model
{
    public class Immuto
    {
        public string Name { get; }

        public Immuto() { }

        public Immuto(string name)
        {
            Name = name;
        }

        public Immuto(XElement element)
        {
            Name = element.Attribute("Name").Value;
        }

        public override string ToString()
        {
            return $"<Immuto {Name}>";
        }
    }
}