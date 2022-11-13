TreeNode mainNode = new()
{
    NameObj = "Иван",
    TypeObj = 0
};
TreeNode firstChildNode = new()
{
    NameObj = "Екатерина",
    TypeObj = 1
};
TreeNode secondChildNode = new()
{
    NameObj = "Евгений",
    TypeObj = 2
};
IList<TreeNode> treeNodes = new List<TreeNode>()
{
    mainNode, firstChildNode, secondChildNode
};

mainNode.Childs.Add(firstChildNode);
mainNode.Childs.Add(secondChildNode);

string separator = new string('-', 100);


Console.WriteLine(separator);
Console.WriteLine("Все объекты:");
foreach (var item in treeNodes)
    Console.WriteLine(item);
Console.WriteLine(separator);

Console.WriteLine($"Есть ли в объекте \"{mainNode.NameObj}\" " +
    $"дочерний объект с названием \"{firstChildNode.NameObj}\" типом \"{firstChildNode.TypeObj}\" : " +
    $"\"{mainNode.HasThisChild(firstChildNode.TypeObj, firstChildNode.NameObj)}\"");
Console.WriteLine(separator);

Console.WriteLine($"Есть ли в объекте \"{mainNode.NameObj}\" " +
    $"дочерний объект с названием \"{secondChildNode.NameObj}\" типом \"{secondChildNode.TypeObj}\" : " +
    $"\"{mainNode.HasThisChild(secondChildNode.TypeObj, secondChildNode.NameObj)}\"");
Console.WriteLine(separator);

Console.WriteLine($"Есть ли в объекте \"{mainNode.NameObj}\" " +
    $"дочерний объект с названием \"{firstChildNode.NameObj}\" типом \"{secondChildNode.TypeObj}\" : " +
    $"\"{mainNode.HasThisChild(secondChildNode.TypeObj, firstChildNode.NameObj)}\"");
Console.WriteLine(separator);
