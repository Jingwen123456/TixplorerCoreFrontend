using NuGet.Protocol.Plugins;

namespace TixplorerCoreFrontend.Models.DTO
{
    public class myFavoriteVM
    {
            public string Account {get; set;}
            public string Pid { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal? Discount { get; set; }
            public int Stock { get; set; }
            public string? Image { get; set; }
        }
}
