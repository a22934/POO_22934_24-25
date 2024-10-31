using System;

namespace ClientManagement_OOP
{
    public class Apartment
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Typology { get; set; }
        public string PropertyType { get; set; }
        public string AdditionalFeatures { get; set; }

        public Apartment(string name, string location, string typology, string propertyType, string additionalFeatures)
        {
            Name = name;
            Location = location;
            Typology = typology;
            PropertyType = propertyType;
            AdditionalFeatures = additionalFeatures;
        }

        public override string ToString()
        {
            // Customize this string to display what you want in the ListBox
            return $"{Name} - {Location} - {Typology} - {PropertyType} - {AdditionalFeatures}";
        }
    }
}