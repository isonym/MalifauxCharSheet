using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Engine.Model;

namespace Engine.Data
{
    public static class FromDataFactory
    {
        public static T Get<T>(string name) where T: class
        {
            string typestring = typeof(T).Name;
            return GetFromXmlFile<T>(name, $@"Data\{typestring}.xml");
        }

        private static T GetFromXmlFile<T>(string name, string filename) where T: class
        {
            XDocument xml = XDocument.Load(filename);
            foreach (XElement element in xml.Root.Elements())
            {
                if (element.Attribute("Name")?.Value == name)
                {
                    return (T) Activator.CreateInstance(typeof(T), element);
                }
            }
            return default(T);
        }

        public static List<T> GetAll<T>() where T : class
        {
            string typestring = typeof(T).Name;
            XDocument xml = XDocument.Load($@"Data\{typestring}.xml");

            List<T> list = new List<T>();
            foreach (XElement element in xml.Root.Elements())
            {
                T result = (T) Activator.CreateInstance(typeof(T), element);
                list.Add(result);
            }

            return list;
        }
    }
}