using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaConverter.Models
{
    public class Tree
    {
        public Tree()
        {
            this.Nodes = new ObservableCollection<TreeNode>();
        }
        public string Headline { get; set; }

        public ObservableCollection<TreeNode> Nodes { get; set; }
    }
}
