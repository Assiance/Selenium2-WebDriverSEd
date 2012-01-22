using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeleniumHelperClasses.Entities.Data
{
    public class TypeSe
    {
        public TypeSe(ElementNames.Name elementName)
        {
            Element = elementName;

            ElementTagLookUp = new Dictionary<ElementNames.Name, string>
            {
                {ElementNames.Name.Button, "input"},
                {ElementNames.Name.CheckBox, "input"},
                {ElementNames.Name.Div, "div"},
                {ElementNames.Name.Image, "img"},
                {ElementNames.Name.Label, "label"},
                {ElementNames.Name.Link, "a"},
                {ElementNames.Name.RadioButton, "input"},
                {ElementNames.Name.SelectList, "select"},
                {ElementNames.Name.Span, "span"},
                {ElementNames.Name.TableBody, "tbody"},
                {ElementNames.Name.TableCell, "td"},
                {ElementNames.Name.TableHead, "thead"},
                {ElementNames.Name.TableRow, "tr"},
                {ElementNames.Name.Table, "table"},
                {ElementNames.Name.TextField, "input"},
            };

            ElementTypeLookUp = new Dictionary<ElementNames.Name, string>
            {
                {ElementNames.Name.Button, "button"},
                {ElementNames.Name.CheckBox, "checkbox"},
                {ElementNames.Name.Div, string.Empty},
                {ElementNames.Name.Image, string.Empty},
                {ElementNames.Name.Label, string.Empty},
                {ElementNames.Name.Link, string.Empty},
                {ElementNames.Name.RadioButton, "radio"},
                {ElementNames.Name.SelectList, string.Empty},
                {ElementNames.Name.Span, string.Empty},
                {ElementNames.Name.TableBody, string.Empty},
                {ElementNames.Name.TableCell, string.Empty},
                {ElementNames.Name.TableHead, string.Empty},
                {ElementNames.Name.TableRow, string.Empty},
                {ElementNames.Name.Table, string.Empty},
                {ElementNames.Name.TextField, "text"},
            };
        }

        private ElementNames.Name Element { get; set; }

        private Dictionary<ElementNames.Name, string> ElementTagLookUp { get; set; }
        private Dictionary<ElementNames.Name, string> ElementTypeLookUp { get; set; }

        public string ToTag()
        {
            return ElementTagLookUp[Element];
        }

        public string ToType()
        {
            return ElementTypeLookUp[Element];
        }

        public override string ToString()
        {
            return Element.ToString();
        }
    }
}