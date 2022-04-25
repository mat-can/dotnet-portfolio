using WebMeni.Models;

namespace WebMeni.Services
{
    public class BeerService : IBeerService
    {
       private List<Beers> _beers = new List<Beers>()
       {
           new Beers(){ Id = 1, Name = "Pilsen", Brand = "Night"},
           new Beers(){ Id = 2, Name = "Heineken", Brand = "0 alcohol"}
       };

       public IEnumerable<Beers> Get() => _beers;
       public Beers? Get(int id) => _beers.FirstOrDefault(x => x.Id == id);
    }
}
