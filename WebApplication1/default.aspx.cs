using RazorEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string template = "Hello @Model.Name! Welcome to Razor!";
            string result = Razor.Parse(template, new { Name = "World" });
            Response.Write(result);
        }
    }
}