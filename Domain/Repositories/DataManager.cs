using MyCompany.Domain.Repositories.Abstract;

namespace MyCompany.Domain.Repositories
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public INewsItemsRepository NewsItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository, INewsItemsRepository newsItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
            NewsItems = newsItemsRepository;
        }
    }
}
