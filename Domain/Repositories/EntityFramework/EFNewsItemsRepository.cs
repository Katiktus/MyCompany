using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain.Entities;

namespace MyCompany.Domain.Repositories.EntityFramework
{
    public class EFNewsItemsRepository: INewsItemsRepository
    {
        private readonly AppDbContext context;
        public EFNewsItemsRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<NewsItem> GetNewsItems()
        {
            return context.NewsItems;
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return context.NewsItems.FirstOrDefault(x => x.Id == id);
        }

        public NewsItem GetNewsItemByTitle(string title)
        {
            return context.NewsItems.FirstOrDefault(x => x.Title == title);
        }

        public void DeleteNewsItem(Guid id)
        {
            context.NewsItems.Remove(new NewsItem() { Id = id });
            context.SaveChanges();
        }

        public void SaveNewsItem(NewsItem item)
        {
            if (item.Id == default)
                context.Entry(item).State = EntityState.Added;
            else
                context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
