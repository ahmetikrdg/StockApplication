using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.EntityCrud
{
    public class EntityByUpdated
    {
        public EntityByUpdated(int id, string Urun)
        {
            int x = id;
            var Update = EntityByConnection.Edmx.StocCard.Find(x);
            Update.STOKID = id;
            Update.Urun = Urun;
            EntityByConnection.Edmx.SaveChanges();
        }
        public EntityByUpdated(int MoveId, int StockId, short Input, short Out)
        {
            int x = MoveId;
            var Update = EntityByConnection.Edmx.StockMovement.Find(x);
            Update.HAREKETID = MoveId;
            Update.STOCKID = StockId;
            Update.GIRIS = Input;
            Update.CIKIS = Out;
            EntityByConnection.Edmx.SaveChanges();
        }
    }
}
