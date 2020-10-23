using System.Collections.Generic;
using AssistAPurchase.Models;

namespace AssistAPurchase.SupportingFunctions
{
    public static class ProductConfigureSupporterFunctions
    {
        public static bool CheckForNullOrMismatchProductNumber(MonitoringItems product, string productNumber)
        {
            if (product == null || product.ProductNumber != productNumber)
            {
                return true;
            }
            return false;
        }
        
        public static List<MonitoringItems> GetItemsAboveTheGivenPrice(string price, List<MonitoringItems> monitoringItems)
        {
            List<MonitoringItems> finalItemsWithPriceAboveCategory = new List<MonitoringItems>();
            foreach (MonitoringItems item in monitoringItems)
            {
                if (float.Parse(item.Price) > float.Parse(price))
                {
                    finalItemsWithPriceAboveCategory.Add(item);
                }
            }
            return finalItemsWithPriceAboveCategory;
        }

        public static List<MonitoringItems> GetItemsBelowTheGivenPrice(string price, List<MonitoringItems> monitoringItems)
        {
            List<MonitoringItems> finalItemsWithPriceBelowCategory = new List<MonitoringItems>();
            foreach (MonitoringItems item in monitoringItems)
            {
                if (float.Parse(item.Price) <= float.Parse(price))
                {
                    finalItemsWithPriceBelowCategory.Add(item);
                }
            }
            return finalItemsWithPriceBelowCategory;
        }

        public static List<MonitoringItems> GetItemsAboveTheGivenScreenSize(string screenSize, List<MonitoringItems> monitoringItems)
        {
            List<MonitoringItems> finalItemWithScreenSizeAboveCategory = new List<MonitoringItems>();
            foreach (MonitoringItems item in monitoringItems)
            {
                if (float.Parse(item.ScreenSize) > float.Parse(screenSize))
                    finalItemWithScreenSizeAboveCategory.Add(item);
            }
            return finalItemWithScreenSizeAboveCategory;
        }

        public static List<MonitoringItems> GetItemsBelowTheGivenScreenSize(string screenSize, List<MonitoringItems> monitoringItems)
        {
            List<MonitoringItems> finalItemWithScreenSizeBelowCategory = new List<MonitoringItems>();
            foreach (MonitoringItems item in monitoringItems)
            {
                if (float.Parse(item.ScreenSize) <= float.Parse(screenSize))
                    finalItemWithScreenSizeBelowCategory.Add(item);
            }
            return finalItemWithScreenSizeBelowCategory;
        }
    }
}