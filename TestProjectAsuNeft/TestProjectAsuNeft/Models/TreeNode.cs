namespace TestProjectAsuNeft.Models;

public class TreeNode : ITreeNode
{
    public int TypeObj { get; set ; }
    public string NameObj { get ; set ; }
    public List<ITreeNode> Childs { get; set; } = new();

    public bool HasThisChild(int typeobj, string nameobj)
    {
        bool hasThisChild = false;

        foreach (var item in Childs)
            if (item.TypeObj == typeobj && item.NameObj== nameobj)
                hasThisChild=true;

        return hasThisChild;
    }
    public override string ToString()
    {
        return $"| Название - {NameObj,-10} | Тип - {TypeObj,-2} |";
    }
}
