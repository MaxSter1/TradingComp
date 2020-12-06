using ManagerMVC.Domain.Repositories.Abstract;

namespace ManagerMVC.Domain
{
    public class DataManager
    {
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(IServiceItemsRepository serviceItemsRepository)
        {
            ServiceItems = serviceItemsRepository;
        }
    }
}
