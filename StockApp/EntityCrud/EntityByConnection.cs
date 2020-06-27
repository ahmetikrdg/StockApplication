using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.EntityCrud
{
    public sealed class EntityByConnection
    {
        private static DB edmx = null;
        private static readonly object padlock = new object();

        private EntityByConnection() { }

        public static DB Edmx
        {
            get
            {
                lock (padlock)
                {
                    if (edmx == null)
                    {
                        edmx = new DB();
                    }
                    return edmx;
                }
            }
        }
    }
}
