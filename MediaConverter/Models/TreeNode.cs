using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaConverter.Models
{
   public class TreeNode
    {
        //Property to save the value of the selection for the content binding of usercontrol in MainWindowModel
        //Property, die den Wert der Auswahl annimmt, um ihn an das Contentbinding zu geben
        //(zum Laden des richtigen Usercontrols)
        public string Select { get; set; }
        public int Case { get; set; }
    }
}
