﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zad4Pai
{
    public partial class Ankieta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mainMultiView.SetActiveView(ankietaGlowna);
                if (Request.QueryString["view"] == "nowy")
                    ankietaMultiView.SetActiveView(nowyView);
                else if (Request.QueryString["view"] == "wycieczki")
                    ankietaMultiView.SetActiveView(wycieczkiView);
                else Response.Redirect("~/Default.aspx");
            }

        }
        protected void wyslijButton_Click(object sender, EventArgs e)
        {
            if (IsValid) { mainMultiView.SetActiveView(podsumowanie); }
        }
        protected void nastepnaCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
        protected void mainMultiView_ActiveViewChanged(object sender, EventArgs e)
        {

        }
        protected void ostatniaCalendar_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}