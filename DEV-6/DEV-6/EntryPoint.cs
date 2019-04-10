using System.Xml;
using System.Collections.Generic;
using System;
using System.Text;
using System.Threading.Tasks;

namespace DEV_6
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            List<Brand> carList = new List<Brand>();
            if (args.Length != 0)
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(args[0]);
                var xmlRoot = xmlDoc.DocumentElement;

                foreach (XmlNode node in xmlRoot)
                {
                    Brand brand = new Brand();
                    XmlNode attr = node.Attributes.GetNamedItem("name");
                    if (attr != null)
                    {
                        brand.name = attr.Value;
                    }

                    foreach (XmlNode models in node.ChildNodes)
                    {
                        Model model = new Model();
                        attr = node.FirstChild.Attributes.GetNamedItem("name");
                        model.name = attr.Value;
                        attr = node.FirstChild;

                        foreach (XmlNode childNode in attr.ChildNodes)
                        {
                            if (childNode.Name == "number")
                            {
                                model.number = int.Parse(childNode.InnerText);
                            }
                            if (childNode.Name == "price")
                            {
                                model.price = int.Parse(childNode.InnerText);
                            }
                        }
                        brand.models.Add(model);
                    }
                    carList.Add(brand);
                }

                foreach(Brand brand in carList)
                {
                    Console.WriteLine(brand.models[0].name);
                }
            }
        }
    }
}
