using System;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Collections.Generic;
using DevExpress.Web.Bootstrap;
using System.Web.UI;
using System.Text;
using System.Web;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Init

        // If you just set this in the control you got problems by rendering the inner controls

        pageControlV.TabPages[1].Visible = false;
        pageControlV.TabPages[2].Visible = false;

        // If you are allowed to view the second tab switch to true
      if (IsAllowedToWatchOtherTab()) pageControlV.TabPages[2].Visible = true;
    }

    Boolean IsAllowedToWatchOtherTab()
    {
        // Very important code to determine if your allowed ... :)
        //*********************
        //
        // True throws the bug , false not
        //
        return true;

        //return false;
    }





  


   

}