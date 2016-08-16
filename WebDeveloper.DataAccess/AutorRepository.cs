using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDeveloper.Model;
using WebDeveloper.Model.DTO;

namespace WebDeveloper.DataAccess
{
    public class AutorRepository : BaseDataAccess<ModelAutor>
    {
        public IEnumerable<AutorModelView> GetListDto()
        {
            using (var dbContext = new WebContextDb())
            {
                return Automapper.GetGeneric<IEnumerable<ModelAutor>,List<AutorModelView>>(dbContext.Autor.ToList());
            }
        }

        //public IEnumerable<AutorModelView> EmailList(int id)
        //{
        //    using (var dbContext = new WebContextDb())
        //    {
        //        return dbContext.Autor.Where(em=> em.AutorId==id).ToList();
        //    }
        //}

        //public ModelLibroAutor GetById(int id)
        //{
        //    using (var dbContext = new WebContextDb())
        //    {
        //        return dbContext.Autor.FirstOrDefault(p => p.AutorId == id);
        //    }
        //}

        public int TotalCount()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Autor.Count();
            }
        }
    }
}
