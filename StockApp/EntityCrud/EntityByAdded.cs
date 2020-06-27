using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.EntityCrud
{
    public class EntityByAdded
    {
        public EntityByAdded(string Product)
        {
            StocCard card = new StocCard();
            card.Urun = Product;
            EntityByConnection.Edmx.StocCard.Add(card);
            EntityByConnection.Edmx.SaveChanges();
        }
        public EntityByAdded(int MoveId, int StockId, short Input, short Out)
        {
            StockMovement movement = new StockMovement();
            movement.HAREKETID = MoveId;
            movement.STOCKID = StockId;
            movement.GIRIS = Input;
            movement.CIKIS = Out;
            EntityByConnection.Edmx.StockMovement.Add(movement);
            EntityByConnection.Edmx.SaveChanges();

        }

    }
}
