/********************************************************
 Name: Bradford Foxworth-Hill
 Email: Brad.Hill@acstechnologies.com
 Alt Email: Assiance@aol.com
 ********************************************************/

using System;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebDriverSEd.Extensions
{
    public static class StringExtensions
    {
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }

            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public static bool IsNullOrEmpty(this string target)
        {
            return string.IsNullOrEmpty(target);
        }

        public static string RemoveLineBreaks(this string theString)
        {
            return theString.Replace("\r", string.Empty).Replace("\n", " ").Replace("<strong>", string.Empty).Replace("</strong>", string.Empty);
        }

        public static string CleanJson(this string target)
        {
            try
            {
                var expectedJson = JObject.Parse(target.Trim());
                return JsonConvert.SerializeObject(expectedJson);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception cleaning Json.");
                throw ex;
            }
        }

        public static string CleanXml(this string target)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                using (XmlWriter writer = XmlWriter.Create(sb))
                {
                    XDocument xml = XDocument.Parse(target.Trim());
                    xml.Save(writer);
                    writer.Flush();
                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception cleaning Xml.");
                throw ex;
            }
        }
    }
}
