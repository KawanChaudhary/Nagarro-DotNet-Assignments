using DomainLayer.Data;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.Concrete
{
    public class BookEventRepository : GenericRepository<BookEventEntity>, IBookEventRepository
    {
        public BookEventRepository(BookEventContext context) : base(context) { }

        public override async Task<bool> Update(BookEventEntity entity)
        {
            try
            {
                var existingEvent = await dbSet.Where(x => x.Id == entity.Id).FirstOrDefaultAsync();

                if (existingEvent == null)
                    return await Add(entity);

                existingEvent = entity;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
