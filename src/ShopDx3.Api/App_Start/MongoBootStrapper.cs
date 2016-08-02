using ShopDx3.DomainModels;
using ShopDx3.DomainModels.Enums;
using MongoDB.Bson.Serialization;

namespace ShopDx3.Api
{
    public static class MongoBootStrapper
    {

        public static void Setup()
        {
            BsonClassMap.RegisterClassMap<ServiceType>(cm =>
            {
                cm.AutoMap();
                cm.SetIsRootClass(true);
            });
            BsonClassMap.RegisterClassMap<ServiceType.DeliveryType>();
            BsonClassMap.RegisterClassMap<ServiceType.InRestaurantType>();
            BsonClassMap.RegisterClassMap<ServiceType.TakeOutType>();

            BsonClassMap.RegisterClassMap<Pizza>(cm =>
            {
                cm.AutoMap();
                cm.GetMemberMap(c => c.Toppings).SetElementName("Topping");
            });

            BsonClassMap.RegisterClassMap<Order>(cm =>
            {
                cm.AutoMap();
                cm.SetIgnoreExtraElements(true);
            });
        
        }         

    }
}