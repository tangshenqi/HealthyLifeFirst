using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLifeFirst
{
    class Class_Item
    {
        /* 
         * This class defines the service methods available for the Item class
         * 
         * Changelog:
         * 2018-04-24 0845 | Sam Teong | Initial Release
         * 
         */

        static public List<Item> GetItemList()
        {
            HLFEntities ctx = new HLFEntities();
            try
            {
                return ctx.Item.ToList();
            }
            catch (Exception) { throw; }
        }
        static public Item SearchItem(string itemID)
        {
            HLFEntities ctx = new HLFEntities();
            try
            {
                return ctx.Item.ToList().Find(x => x.ItemID == itemID);
            }
            catch (Exception) { throw; }
        }
        static public string AddItem(Item item)
        {
            HLFEntities ctx = new HLFEntities();
            try
            {
                ctx.Item.Add(item);
                ctx.SaveChanges();
                return HLFMsg.AddItemOKMsg;
            }
            catch (Exception) { return HLFMsg.AddItemNGMsg; throw; }
        }
        static public string UpdateItem(Item item)
        {
            HLFEntities ctx = new HLFEntities();
            try
            {
                Item original = SearchItem(item.ItemID);
                if (original == null) { return HLFMsg.FindItemNGMsg; }
                original = item;
                ctx.SaveChanges();
                return HLFMsg.UpdateItemOKMsg;
            }
            catch (Exception) { return HLFMsg.UpdateItemNGMsg;  throw; }
        }
        static public string RemoveItem(string itemID)
        {
            HLFEntities ctx = new HLFEntities();
            try
            {
                Item original = SearchItem(itemID);
                if (original == null) { return HLFMsg.FindItemNGMsg; }
                ctx.Item.Remove(original);
                ctx.SaveChanges();
                return HLFMsg.RemoveItemOKMsg;
            }
            catch (Exception) { return HLFMsg.RemoveItemNGMsg; throw; }
        }
    }
}
