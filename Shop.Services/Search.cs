using Shop.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shop.Domain;

namespace Shop.Services
{
  public class Search
  {
    public IQueryable<Item> ToSearch(ShopContext context, string nameItem) 
    {
      var result = context.Items.Where(name => name.Name.Contains(nameItem));
      return result;
    }
    public List<Item> ToPagination(IQueryable<Item> result, int count = 0, int page = 0)
    {
      var paginationResult = result.Skip(page * count).Take(count);
      var items = paginationResult.ToList();

      return items;
    }
  }
}
