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

public partial class Pages_Admin_ManageProjectorBrand : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProjectorBrand model = new ProjectorBrand();
        ProductBrand pt = CreateProductBrand();

        lblResult.Text = model.InsertProductBrand(pt);
    }

    private ProductBrand CreateProductBrand()
    {
        ProductBrand p = new ProductBrand();
        p.ProjectorBrandName = txtProjectorBrand.Text;

        return p;
    }
}