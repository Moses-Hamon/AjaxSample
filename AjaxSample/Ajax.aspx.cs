using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AjaxSample
{
    public partial class Ajax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var command = Request.QueryString["cmd"];
            switch (command)
            {
                case "hello":
                    HelloWorld();
                    break;
                case "add":
                    Add();
                    break;
            }
        }

        private void Add()
        {
            var arg = Request.QueryString["arg"];
            var args = arg.Split(',');
            var num1 = Convert.ToInt32(args[0]);
            var num2 = Convert.ToInt32(args[1]);
            lblOutput.Text = $"Total:{num1} + {num2} = {num1 + num2}";

        }

        private void HelloWorld()
        {
            lblOutput.Text = "Hello World.";
        }

    }
}