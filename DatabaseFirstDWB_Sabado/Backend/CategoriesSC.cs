using DatabaseFirstDWB_Sabado.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseFirstDWB_Sabado.Backend
{
    class CategoriesSC
    {
        NorthwindContext dataContext = new NorthwindContext();

        public IQueryable<Categories> GetAllCategories()
        {
            return dataContext.Categories.Select(s => s);
        }
    }
}
