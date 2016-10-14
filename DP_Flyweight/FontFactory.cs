using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Flyweight
{
    class FontFactory
    {
        public Dictionary<string,FontBase> FontsDictionary = new   Dictionary<string, FontBase>();

        public FontBase CreateFont(string fontName)
        {
            if (FontsDictionary.ContainsKey(fontName))
            {
                return FontsDictionary[fontName];
            }
            return new FontBase(fontName);
        }

        public bool AddFont(FontBase fontBase)
        {
            if (FontsDictionary.ContainsValue(fontBase))
            {
                Console.WriteLine("Font already exists!");
                return false;
            }
            FontsDictionary.Add(fontBase.FontName, fontBase);
            return true;
        }
    }
}
