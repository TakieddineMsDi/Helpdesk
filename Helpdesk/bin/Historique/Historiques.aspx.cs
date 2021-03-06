﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Helpdesk
{
    public partial class Historiques : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Changed"] = null;
            Utilitaire.Databases.Scripts.CheckStatut(msgboxpanel);
        }
        protected void GridView1_IndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sValue = ((HiddenField)GridView1.SelectedRow.Cells[1].FindControl("HiddenField1")).Value;
            Utilitaire.Utilites.redirect("AgenceHistorique.aspx?Zone=" + sValue);
        }
    }
}