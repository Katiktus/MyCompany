using System;
using System.Linq;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories
{
    public interface INewsItemsRepository
    {
        IQueryable<NewsItem> GetNewsItems();
        NewsItem GetNewsItemById(Guid id);
        NewsItem GetNewsItemByTitle(string title);
        void SaveNewsItem(NewsItem entity);
        void DeleteNewsItem(Guid id);
    }
}