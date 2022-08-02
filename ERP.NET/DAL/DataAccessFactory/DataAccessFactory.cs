using DAL.EF;
using DAL.Interfaces.Common;
using DAL.Repo.ProductManagerRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataAccessFactory
{
    public class DataAccessFactory
    {
        static ERPEntities db = new ERPEntities();
        public static IRepo<Product, int, bool> ProductDataAccess()
        {
            return new ProductRepo(db);
        }
    }
}
