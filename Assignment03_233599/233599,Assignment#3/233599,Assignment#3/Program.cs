using System;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        CreateXML();
        ReadXML();
    }

    static void CreateXML()
    {
        XmlWriterSettings settings = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "\t"
        };

        using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
        {
            writer.WriteStartDocument();
            writer.WriteStartElement("GPS_Log");

            writer.WriteStartElement("Position");
            writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
            writer.WriteElementString("x", "65.8973342");
            writer.WriteElementString("y", "72.3452346");

            writer.WriteStartElement("SatteliteInfo");
            writer.WriteElementString("Speed", "40");
            writer.WriteElementString("NoSatt", "7");
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteStartElement("Image");
            writer.WriteAttributeString("Resolution", "1024x800");
            writer.WriteElementString("Path", @"\images\1.jpg");
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
        }

        Console.WriteLine("XML file 'GPS.xml' created successfully.");
    }

    static void ReadXML()
    {
        using (XmlReader reader = XmlReader.Create("GPS.xml"))
        {
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    Console.WriteLine($"Element: {reader.Name}");
                }
                else if (reader.NodeType == XmlNodeType.Text)
                {
                    Console.WriteLine($"Value: {reader.Value}");
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    Console.WriteLine($"End Element: {reader.Name}");
                }
                else if (reader.NodeType == XmlNodeType.Attribute)
                {
                    Console.WriteLine($"Attribute: {reader.Name} = {reader.Value}");
                }
            }
        }
    }
}
