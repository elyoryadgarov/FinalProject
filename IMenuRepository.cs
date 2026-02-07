using PizzaMaze.Models;

namespace PizzaMaze
{
    public interface IMenuRepository
    {
        public IEnumerable<Menu> GetMenu();
    }
}

