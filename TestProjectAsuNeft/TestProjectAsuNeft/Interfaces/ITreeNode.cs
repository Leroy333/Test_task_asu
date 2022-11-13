using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectAsuNeft.Interfaces;

public interface ITreeNode
{
    int TypeObj { get; set; }
    string NameObj { get; set; }
    List<ITreeNode> Childs { get; set; }
    bool HasThisChild(int typeobj, string nameobj);
}
