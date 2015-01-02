﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace XpremaBeam
{
   public class Operation
    {
      

       public static void ShowToustOk(string msg, Control frm)
       {
           frm.Invoke((MethodInvoker)delegate {

               ToastNotification.Show(frm, msg, null, 1000, eToastGlowColor.Green, eToastPosition.MiddleCenter);
    
           });
       }

       public static void BeginOperation(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate {

               frm.Enabled = false;
               frm.Cursor = Cursors.WaitCursor;
           
           });
       }

       public static void EndOperation(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate
           {

               frm.Enabled = true;
               frm.Cursor = Cursors.Default;

           });
       }
    }
}
