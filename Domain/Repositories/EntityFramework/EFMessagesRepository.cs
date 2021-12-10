using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;
using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFMessagesRepository : IMessagesRepository
    {
        private readonly AppDbContext context;
        public EFMessagesRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Message> GetMessages()
        {
            return context.Messages;
        }


        public void DeleteMessages(Guid id)
        {
            context.Messages.Remove(new Message() { Id = id });
            context.SaveChanges();
        }

        public void SaveMessages(Message entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public Message GetMessageById(Guid id)
        {
            return context.Messages.FirstOrDefault(x => x.Id == id);
        }
    }
}
