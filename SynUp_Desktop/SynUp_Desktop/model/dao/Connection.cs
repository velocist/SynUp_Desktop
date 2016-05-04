using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SynUp_Desktop.model.pojo;

namespace SynUp_Desktop.model.dao
{
    ///<summary>
    ///Data Access Object Class that will access the database and interact directly with it. 
    ///</summary>
    ///<Author>Pablo Ardèvol</Author>
    ///<Version>0.01</Version>
    ///<Date>04/05/2016_1713</Date>
    public static class Connection
    {
        private static synupEntities database = new synupEntities();

        private static bool commitChanges()
        {
            try
            {
                database.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



    }
}
