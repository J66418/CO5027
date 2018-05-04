/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Admin_TBProjectors : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void grdProjectorType_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Get selected row
        GridViewRow row = grdProjectorType.Rows[e.NewEditIndex];

        //Get Id of selected product
        int rowProjectorTypeID = Convert.ToInt32(row.Cells[1].Text);

        //Redirect user to ManageProducts along with the selected rowId
        Response.Redirect("~/Pages/Admin/ManageProjectorType.aspx?id= " + rowProjectorTypeID);

    }

    protected void grdProjectorbrand_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Get selected row
        GridViewRow row = grdProjectorBrand.Rows[e.NewEditIndex];

        //Get Id of selected product
        int rowProjectorBrandID = Convert.ToInt32(row.Cells[1].Text);

        //Redirect user to ManageProducts along with the selected rowId
        Response.Redirect("~/Pages/Admin/ManageProjectorBrand.aspx?id= " + rowProjectorBrandID);

    }
}