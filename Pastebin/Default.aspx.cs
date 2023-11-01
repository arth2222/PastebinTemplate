using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pastebin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Det er 2 situasjoner. 
            //1. Det skal hentes en paste, det er da en qs
            //2. Det er ikke en qs, en ny paste skal lages, og settes inn i db
            LabelQS.Text = Request.QueryString["code"];
            if (LabelQS.Text.Length > 0)//om det faktisk er en qs der, gå videre og hent fra db
                GetPaste();
        }

        private void GetPaste()
        {
            //do database stuff - select * from mytable where code=thecode
            //bind text to a control. Label, textarea etc.
        }

        private void InsertPaste()
        {
            //Generate unique paste code.
            //Insert text from webform, and unique code, and other stuff if needed, to database.
            //what happens after a paste is created?
        }
    }
}