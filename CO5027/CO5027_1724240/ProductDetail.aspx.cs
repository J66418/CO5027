/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Linq;
using Microsoft.AspNet.Identity;


public partial class ProductDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            string CustomerID = Context.User.Identity.GetUserId();

            if (CustomerID != null)
            {

                int ProjectorID = Convert.ToInt32(Request.QueryString["id"]);
                int AmountPurchased = Convert.ToInt32(ddlAmount.SelectedValue);

                ShoppingCart cart = new ShoppingCart
                {
                    AmountPurchased = AmountPurchased,
                    CustomerID = CustomerID,
                    DatePurchased = DateTime.Now,
                    ProjectorInCart = true,
                    ProjectorID = ProjectorID,
                };

                ShopCart model = new ShopCart();
                lblResult.Text = model.InsertShoppingCart(cart);
            }
            else
            {
                lblResult.Text = "Please log in to order items";
            }
        }
    }

    private void FillPage()
    {
        //Get selected product data
        if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            Projector model = new Projector();
            Product product = model.GetProduct(id);

            //Fill page with data
            lblTitle.Text = product.ProjectorName;
            lblDescription.Text = product.Description;
            lblPrice.Text = "Price per unit:<br/>$ " + product.Price;
            imgProduct.ImageUrl = "~/Images/Product/" + product.Image;
            lblItemNr.Text = product.ProjectorID.ToString();

            //Fill amount list with numbers 1-50
            int[] amount = Enumerable.Range(1, 50).ToArray();
            ddlAmount.DataSource = amount;
            ddlAmount.AppendDataBoundItems = true;
            ddlAmount.DataBind();
        }
    }
}