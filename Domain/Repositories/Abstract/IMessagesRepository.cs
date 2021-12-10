using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.Abstract
{
    public interface IMessagesRepository
    {
        IQueryable<Message> GetMessages();

        Message GetMessageById(Guid id);
        void SaveMessages(Message entity);
        void DeleteMessages(Guid id);
    }
}
