#region Book
using Composite.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICorporationFactory, DefaultCorporationFactory>();

var app = builder.Build();

app.MapGet(
    "/",
    (ICorporationFactory corporationFactory)
        => corporationFactory.Create()
);

app.Run();



#endregion


#region Simple
//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//var CarBrand = new CompositeComponent("BMW");

//var Engine = new CompositeComponent("Engine");
//var Dashboard = new CompositeComponent("Dashboard");

//var Cylinders = new LeafComponent("Cylinders");
//var Airvents = new LeafComponent("Airvents");

//Engine.Add(Cylinders);
//Dashboard.Add(Airvents);

//CarBrand.Add(Engine);
//CarBrand.Add(Dashboard);

//app.MapGet("/carstructure", () => CarBrand.Display(1));

//app.Run();



//interface IComponent
//{
//    void Display(int depth);
//}


//class CompositeComponent : IComponent
//{
//    private readonly string _name;
//    private readonly List<IComponent> _children = new();

//    public CompositeComponent(string name)
//    {
//        _name = name;
//    }

//    public void Add(IComponent component)
//    {
//        _children.Add(component);
//    }

//    public void Remove(IComponent component)
//    {
//        _children.Remove(component);
//    }

//    public void Display(int depth)
//    {
//        Console.WriteLine(new string('-', depth) + _name);

//        foreach (var child in _children)
//        {
//            child.Display(depth + 2);
//        }
//    }
//}


//class LeafComponent : IComponent
//{
//    private readonly string _name;

//    public LeafComponent(string name)
//    {
//        _name = name;
//    }

//    public void Display(int depth)
//    {
//        Console.WriteLine(new string('-', depth) + _name);
//    }
//}
#endregion