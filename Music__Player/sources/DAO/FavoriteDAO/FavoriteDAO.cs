using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.FavoriteDAO
{
    public class FavoriteDAO
    {
        private static FavoriteDAO instance;
        public static FavoriteDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FavoriteDAO();

                return instance;
            }
            private set { instance = value; }
        }

        private FavoriteDAO() { }


    }
}
