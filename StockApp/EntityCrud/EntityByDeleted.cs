using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.EntityCrud
{
    public class EntityByDeleted
    {
        public void EntityByDeletedCard(int id)
        {
            int x = Convert.ToInt32(id);
            var Search = EntityByConnection.Edmx.StocCard.Find(id);
            EntityByConnection.Edmx.StocCard.Remove(Search);
            EntityByConnection.Edmx.SaveChanges();
        }
        public void EntityByDeletedMovements(int id)
        {
            int x = Convert.ToInt32(id);
            var Search = EntityByConnection.Edmx.StockMovement.Find(id);
            EntityByConnection.Edmx.StockMovement.Remove(Search);
            EntityByConnection.Edmx.SaveChanges();
        }
    }
}
