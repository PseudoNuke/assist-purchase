using System.Collections.Generic;
using AssistAPurchase.Models;
using AssistAPurchase.Database;

namespace AssistAPurchase.Repository
{
    public class MonitoringProductRepository : IMonitoringProductRepository
    {
        protected readonly List<MonitoringItems> MonitoringItems = new List<MonitoringItems>();

        public MonitoringProductRepository()
        {
            var products = new MonitoringProductsGetter().Products;
            foreach (MonitoringItems item in products)
            {
                Add(item);
            }
        }

        public List<MonitoringItems> GetAll()
        {
            return MonitoringItems;
        }

        public Add(MonitoringItems item)
        {
            MonitoringItems.Add(item);
        }

        public MonitoringItems Find(string productNumber)
        {
            foreach (MonitoringItems item in MonitoringItems)
            {
                if (item.ProductNumber == productNumber)
                {
                    return item;
                }
            }
        }

        public MonitoringItems Remove(string productNumber)
        {
            for (var i = 0; i < MonitoringItems.Count; i++)
            {
                if (MonitoringItems[i].ProductNumber == productNumber)
                {
                    var currentItem = MonitoringItems[i];
                    MonitoringItems.RemoveAt(i);
                    return currentItem;
                }
            }
            return null;
        }

        public string Update(MonitoringItems product)
        {
            var currentProductNumber = product.ProductNumber;
            for (var i = 0; i < MonitoringItems.Count; i++)
            {
                if (MonitoringItems[i].ProductNumber == currentProductNumber)
                {
                    MonitoringItems.RemoveAt(i);
                    MonitoringItems.Add(product);
                    string message = "Updated Successfully";
                    return message;
                }
            }
            return null;
        }
    }
}