/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

public partial class ShopCartDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Check if user is logged in
        string customerID = User.Identity.GetUserId();

        //Display all items in user's cart.
        GetPurchasesInCart(customerID);
    }

    protected void Delete_Item(object sender, EventArgs e)
    {
        LinkButton selectedLink = (LinkButton)sender;
        string link = selectedLink.ID.Replace("del", "");
        int ShoppingCartID = Convert.ToInt32(link);

        var ShopCart = new ShopCart();
        ShopCart.DeleteShoppingCart(ShoppingCartID);

        Response.Redirect("~/ShopCartDetail.aspx");
    }

    private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Get ID of product that has had its quantity dropdownlist changed.
        DropDownList selectedList = (DropDownList)sender;
        int ShoppingCartID = Convert.ToInt32(selectedList.ID);
        int Quantity = Convert.ToInt32(selectedList.SelectedValue);

        //Update purchase with new quantity and refresh page
        ShopCart ShopCart = new ShopCart();
        ShopCart.UpdateQuantity(ShoppingCartID, Quantity);
        Response.Redirect("~/ShopCartDetail.aspx");
    }

    private void GetPurchasesInCart(string CustomerID)
    {
        ShopCart ShopCart = new ShopCart();
        double subTotal = 0;

        //Get all purchases for current user and display in table
        List<ShoppingCart> purchaseList = ShopCart.GetOrdersInCart(CustomerID);
        CreateShopTable(purchaseList, out subTotal);

        //Add totals to webpage
        double totalAmount = subTotal;

        litTotal.Text = "BND$ " + subTotal;
        litTotalAmount.Text = "BND$ " + totalAmount;
    }

    private void CreateShopTable(IEnumerable<ShoppingCart> ShopCarts, out double subTotal)
    {
        subTotal = new double();
        Projector model = new Projector();

        foreach (ShoppingCart shoppingcart in ShopCarts)
        {
            //Create HTML elements and fill values with database data
            Product product = model.GetProduct(shoppingcart.ProjectorID);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Images/Product/{0}", product.Image),
                PostBackUrl = string.Format("~/Default.aspx?id={0}", product.ProjectorID)
            };

            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/ShopCartDetail.aspx?productId={0}", shoppingcart.ShoppingCartID),
                Text = "Delete Item",
                ID = "del" + shoppingcart.ShoppingCartID,
            };

            lnkDelete.Click += Delete_Item;

            //Fill amount list with numbers 1-50
            int[] amountpurchased = Enumerable.Range(1, 50).ToArray();
            DropDownList ddlAmount = new DropDownList
            {
                DataSource = amountpurchased,
                AppendDataBoundItems = true,
                AutoPostBack = true,
                ID = shoppingcart.ShoppingCartID.ToString()
            };
            ddlAmount.DataBind();
            ddlAmount.SelectedValue = shoppingcart.AmountPurchased.ToString();
            ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

            //Create table to hold shopping cart details
            Table table = new Table { CssClass = "CartTable" };
            TableRow row1 = new TableRow();
            TableRow row2 = new TableRow();

            TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
            TableCell cell1_2 = new TableCell
            {
                Text = string.Format("<h4>{0}</h4><br />{1}<br/>In Stock",
                product.ProjectorName, "Item No:" + product.ProjectorID),
                HorizontalAlign = HorizontalAlign.Left,
                Width = 350,
            };
            TableCell cell1_3 = new TableCell { Text = "Unit Price<hr/>" };
            TableCell cell1_4 = new TableCell { Text = "Quantity<hr/>" };
            TableCell cell1_5 = new TableCell { Text = "Item Total<hr/>" };
            TableCell cell1_6 = new TableCell();

            TableCell cell2_1 = new TableCell();
            TableCell cell2_2 = new TableCell { Text = "BND$" + product.Price };
            TableCell cell2_3 = new TableCell();
            TableCell cell2_4 = new TableCell { Text = "BND$" + Math.Round((shoppingcart.AmountPurchased * product.Price), 2) };
            TableCell cell2_5 = new TableCell();



            //Set custom controls
            cell1_1.Controls.Add(btnImage);
            cell1_6.Controls.Add(lnkDelete);
            cell2_3.Controls.Add(ddlAmount);

            //Add rows & cells to table
            row1.Cells.Add(cell1_1);
            row1.Cells.Add(cell1_2);
            row1.Cells.Add(cell1_3);
            row1.Cells.Add(cell1_4);
            row1.Cells.Add(cell1_5);
            row1.Cells.Add(cell1_6);

            row2.Cells.Add(cell2_1);
            row2.Cells.Add(cell2_2);
            row2.Cells.Add(cell2_3);
            row2.Cells.Add(cell2_4);
            row2.Cells.Add(cell2_5);
            table.Rows.Add(row1);
            table.Rows.Add(row2);
            pnlShoppingCart.Controls.Add(table);

            //Add total of current purchased item to subtotal
            subTotal += (shoppingcart.AmountPurchased * (double)product.Price);
        }

        //Add selected objects to Session
        Session[User.Identity.GetUserId()] = ShopCarts;
    }
}