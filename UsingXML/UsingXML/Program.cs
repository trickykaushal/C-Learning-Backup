using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

using System.Xml;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.IO;

namespace XMLdemo1
{
    class Program
    {


        public static void Main()
        {





            var k = @"
<Date-KnockOut-rule appform-id=""0"" form=""Yes"" datecontrol-id=""53"" field-name=""PRINCIPAL BORROWER/Date of Birth"" condition=""lt"" condition-text=""&lt;"" value=""18"" __id=""2"" />
";
            var flow = k.ToString();
            var xml = @"<Date-KnockOut-rule appform-id=""0"" form=""Yes"" datecontrol-id=""53"" field-name=""PRINCIPAL BORROWER/Date of Birth"" condition=""lt"" condition-text=""&lt;"" value=""18"" __id=""2"" />";

        var serializer = new XmlSerializer(typeof(DateKnockOutRule));
            using (StringReader reader = new StringReader(xml))
            {
                var rule = (DateKnockOutRule)serializer.Deserialize(reader);
            }
            //List<XmlNode> nodelist = docFlow.SelectNodeList("data-form/field");


            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(k);
            XmlNode ageNode = xmlDoc.SelectSingleNode("Records/person/age");
            //ageNode.InnerText = "45";
            //if (ageNode != null)
            //{
            //    string age = ageNode.InnerText;
            //    Console.WriteLine(age);
            //}

            XmlElement newElement = xmlDoc.CreateElement("location");
            newElement.InnerText = "New York";
            xmlDoc.DocumentElement.AppendChild(newElement);


            XmlNode location = xmlDoc.SelectSingleNode("/location");

            if (location != null)
            {
                string age = location.InnerText;
                Console.WriteLine(age);
            }



            if (true)
            {
                string jsonSubString = JsonConvert.SerializeObject("fdjlfjd");
                XNode node = JsonConvert.DeserializeXNode(jsonSubString);
            }


        }

    }


    [XmlRoot("Date-KnockOut-rule")]
    public class DateKnockOutRule
    {
        [XmlAttribute("appform-id")]
        public string AppFormId { get; set; }

        [XmlAttribute("form")]
        public string Form { get; set; }

        [XmlAttribute("datecontrol-id")]
        public string DateControlId { get; set; }

        [XmlAttribute("field-name")]
        public string FieldName { get; set; }

        [XmlAttribute("condition")]
        public string Condition { get; set; }

        [XmlAttribute("condition-text")]
        public string ConditionText { get; set; }

        [XmlAttribute("value")]
        public string Value { get; set; }

        [XmlAttribute("__id")]
        public string Id { get; set; }
    }

}