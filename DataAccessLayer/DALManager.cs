using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DALManager
    {

        private static DALManager _instance;
        private static readonly object padlock = new object();
        public IDAL _DALServer { get; private set; }

        public static DALManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DALManager(new DALSQLServer());
                        }
                    }
                }
                return _instance;
            }

        }

        private DALManager(IDAL DAL)
        {
            _DALServer = DAL;
        }
    }
}
