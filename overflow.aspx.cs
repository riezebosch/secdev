using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class overflow : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //ENTER checked OR unchecked
        unchecked
        {
            int i = int.MaxValue;
            i++;
            Label1.Text = i.ToString();
        }

    }
}
