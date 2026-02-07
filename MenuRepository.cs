using System.Data;
using PizzaMaze.Models;
using Dapper;

namespace PizzaMaze
{
   public class MenuRepository : IMenuRepository
   {
      private readonly IDbConnection _conn;

      public MenuRepository(IDbConnection conn)
      {
         _conn = conn;
      }

      public IEnumerable<Menu> GetMenu()
      {
         return _conn.Query<Menu>("SELECT * FROM Menu;");
      }
   } 
}

