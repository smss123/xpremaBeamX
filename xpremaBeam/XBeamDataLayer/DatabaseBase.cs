using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace XBeamDataLayer
{
  public  class DatabaseBase
    {
      
   protected  static dbDataContext db = new dbDataContext();
     public  delegate void ConnectionFlageCallBack(object sender, string status);
     public static  event ConnectionFlageCallBack OnConnectionChange;

     Thread th = null;
     public static void StartConnection()
     {
         db.Connection.StateChange += Connection_StateChange;
         if (db.Connection.State!=System.Data.ConnectionState.Open)
         {
             db.Connection.OpenAsync();
             OnConnectionChange(null, db.Connection.State.ToString());
         }
     }

     static void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
     {
         OnConnectionChange(e.OriginalState, e.CurrentState.ToString());
     }

     public static void StopConnection()
     {
         db.Connection.Close();
         OnConnectionChange(null, db.Connection.State.ToString());
     }

    }
}
