using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Engine.Model
{
    public class Magia
    {
        public string Name { get; }
        public string MagiaClass { get; }
        public string Aspect { get; }
        public int ActionPoints { get; }
        public int TargetNumber { get; }
        public string Resist { get; }
        public int Range { get; }
        public string Effect { get; }
        public string Requirements { get; }

        public Magia(string name)
        {
            Name = name;
        }

        public Magia() { }

        public Magia(XElement element)
        {
            Name = element.Attribute("Name").Value;
        }

        public override string ToString()
        {
            return $"<Magia {Name}>";
        }
    }
}