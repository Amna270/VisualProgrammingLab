using System;
using System.Runtime.InteropServices;
using System.Xml;
namespace assignment03
{
    class Program
    {
        static void Main()
        {
            CreateXml();
            ReadXml();
        }
        static void CreateXml()
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };
            using (XmlWriter writer=XmlWriter.Create("GPS.xml",settings))
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
        static void ReadXml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Gps.xml");
            XmlNode root = doc.DocumentElement;
            Console.WriteLine("Reading GPS Log: ");
            foreach(XmlNode node in root.ChildNodes)
            {
                if(node.Name=="Position")
                {
                    Console.WriteLine($"Position (DateTime: {node.Attributes["DateTime"].Value}):");
                    Console.WriteLine($"x: {node["x"].InnerText}");
                    Console.WriteLine($"y: {node["y"].InnerText}");
                    XmlNode satInfo = node["SatteliteInfo"];
                    Console.WriteLine("Satellite Info:");
                    Console.WriteLine($"Speed: {satInfo["Speed"].InnerText}");
                    Console.WriteLine($"NoSatt: {satInfo["NoSatt"].InnerText}");
                }
                else if(node.Name=="Image")
                {
                    Console.WriteLine($"Imgae (Resolution: {node.Attributes["Resolution"].Value}):");
                    Console.WriteLine($"Path: {node["Path"].InnerText}");
                }
            }
        }
    }
}