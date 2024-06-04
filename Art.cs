using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog122_L14_Notes_Week10
{
    public class Art
    {
        //Enumerables
        // Keyword: enum
        //Fields
        public enum STYLE { Abstract, Impressionism, Cubism }
        STYLE _style;
        string _name;

        

        //Constructor
        public Art(string name, STYLE style)
        {
            _name = name;
            _style = style;


        }
        //Properties

        public STYLE Style { get => _style; set => _style = value; }
        public string Name { get => _name; set => _name = value; }

        //Method

        public override string ToString()
        {
            return $"{_name} - {_style}";
        }
    }//end class
}//end namespace
