using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppProcess.BusinessLayer;

namespace WebAppProcess
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			string input = txtvalue.Text;
			Extract ex = new Extract();


			GridView1.DataSource = ex.FormatInput(input);
			GridView1.DataBind();
		}
	}
}