using ConsoleApp3.Models;

namespace ConsoleApp3
{
    public interface IMenuRepository
    {
        public IEnumerable<Menu> GetMenu();
    }
}

