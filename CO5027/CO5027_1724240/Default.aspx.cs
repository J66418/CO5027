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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        //Get a list of all products in DB
        Projector projector = new Projector();
        List<Product> products = projector.GetAllProducts();

        //Make sure products exist in the database
        if (products != null)
        {
            //Create a new Panel with an ImageButton and 2 abels for each Product
            foreach (Product product in products)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblProductName = new Label();
                Label lblPrice = new Label();

                //Set childConrol's properties
                imageButton.ImageUrl = "~/Images/Product/" + product.Image;
                imageButton.CssClass = "productImage";
                imageButton.PostBackUrl = "~/ProductDetail.aspx?id=" + product.ProjectorID;

                lblProductName.Text = product.ProjectorName;
                lblProductName.CssClass = "productName";

                lblPrice.Text = "$" + product.Price;
                lblPrice.CssClass = "productPrice";

                //Add child control to Panel
                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblProductName);
                productPanel.Controls.Add(new Literal { Text = "<br/>" });
                productPanel.Controls.Add(lblPrice);

                //Add dynamic Panels to static Parent panel
                pnlProducts.Controls.Add(productPanel);
            }
        }
        else
        {
            //No products found
            pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
        }
    }
}