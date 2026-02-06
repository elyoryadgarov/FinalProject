using System.Data;
using ConsoleApp3.Models;
using Dapper;

namespace ConsoleApp3
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

