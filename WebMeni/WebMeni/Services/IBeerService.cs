using WebMeni.Models;

namespace WebMeni.Services
{
    public interface IBeerService
    {
        public IEnumerable<Beers> Get();
        public Beers? Get(int Id);
    }
}
