using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            switch (txtCommand.Text)
            {
                case "hello": Hello(); break;
                case "add": Add(); break;
            }

        }
        private void Hello()
        {
            lblResults.Text = "Hello World";
        }
        private void Add()
        {
            var numbers = txtArgument.Text.Split(',');
            var num1 = Convert.ToInt32(numbers[0]);
            var num2 = Convert.ToInt32(numbers[1]);
            lblResults.Text = (num1 + num2).ToString();
        }
    }
}