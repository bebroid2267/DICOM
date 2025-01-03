using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace DICOM
{
    public static class DICOM
    {
        public static Dictionary<string, DICOM_VR> vrCollection = new Dictionary<string, DICOM_VR>();
        public static Dictionary<string, Dictionary<string, DICOM_Element>> elementsCollection = new Dictionary<string, Dictionary<string, DICOM_Element>>();

        public static void Load(string vrXmlFile, string elementsXmlFile)
        {
            LoadVRFromXml(vrXmlFile);
            LoadElementsFromXml(elementsXmlFile);
        }

        private static void LoadVRFromXml(string xmlFile)
        {
            XElement xml = XElement.Load(xmlFile);
            foreach (var vrElement in xml.Elements("VR"))
            {
                string name = vrElement.Attribute("Name").Value;
                string description = vrElement.Element("Description").Value;
                string pseudoType = vrElement.Element("PseudoType").Value;
                var dicom_VR = new DICOM_VR(name, description, pseudoType);
                vrCollection[name] = dicom_VR;
            }
        }

        private static void LoadElementsFromXml(string xmlFile)
        {
            XElement xml = XElement.Load(xmlFile);
            foreach (var element in xml.Elements("Element"))
            {
                string groupId = element.Attribute("GroupID").Value;
                string elementId = element.Attribute("ElementID").Value;
                string vr = element.Element("VR").Value;
                string name = element.Element("Name").Value;
                if (!elementsCollection.ContainsKey(groupId))
                    elementsCollection[groupId] = new Dictionary<string, DICOM_Element>();
                var dicomElement = new DICOM_Element(groupId, elementId, vr, name);
                elementsCollection[groupId][elementId] = dicomElement;
            }
        }

        public static DICOM_VR FindVR(string name)
        {
            vrCollection.TryGetValue(name, out var dicom_VR);
            return dicom_VR;
        }

        public static DICOM_Element FindElement(string groupId, string elementId)
        {
            DICOM_Element element;
            if (elementId == "0000")
            {
                element = new DICOM_Element(groupId, elementId, "UL", "Group Length");
            }
            else if (elementsCollection.TryGetValue(groupId, out var elements))
            {
                elements.TryGetValue(elementId, out var dicomElement);
                element = dicomElement == null ? new DICOM_Element(groupId, elementId, "UN", "Unknown") : dicomElement;
            }
            else
            {
                element = new DICOM_Element(groupId, elementId, "UN", "Unknown");
            }
            return element;
        }
        public static IEnumerable<DICOM_Element> GetAllElements()
        {
            return elementsCollection.Values.SelectMany(g => g.Values);
        }

        public static IEnumerable<DICOM_VR> GetAllVRs()
        {
            return vrCollection.Values;
        }
    }

    public class DICOM_VR
    {
        public string Name;
        public string Description;
        public string PseudoType;
        public DICOM_VR(string name, string description, string pseudoType)
        {
            Name = name;
            Description = description;
            PseudoType = pseudoType;
        }
    }

    public class DICOM_Element
    {
        public long Length;
        public string GroupID;
        public string ElementID;
        public string VR;
        public string Name;
        public string Tag => $"({GroupID},{ElementID})";
        public DICOM_Element(string groupId, string elementId, string vr, string name)
        {
            GroupID = groupId;
            ElementID = elementId;
            VR = vr;
            Name = name;
        }
        public bool IsPixelData { get { return (GroupID == "7FE0") && (ElementID == "0010"); } }
        public override string ToString() => this.GroupID + ", " + this.ElementID;
    }
}