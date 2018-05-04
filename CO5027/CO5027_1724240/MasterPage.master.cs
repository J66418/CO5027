/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Web;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var user = Context.User.Identity;
        if (user.IsAuthenticated)
        {
            litStatus.Text = Context.User.Identity.Name;
            lnkLogIn.Visible = false;
            lnkRegister.Visible = false;

            litStatus.Visible = true;
            lnkLogOut.Visible = true;

            ShopCart model = new ShopCart();
            string customerID = HttpContext.Current.User.Identity.GetUserId();
            litStatus.Text = string.Format("{0} ({1})", Context.User.Identity.Name, model.GetAmountOfOrders(customerID));
        }
        else
        {
            lnkLogIn.Visible = true;
            lnkRegister.Visible = true;

            litStatus.Visible = false;
            lnkLogOut.Visible = false;
        }
    }
    protected void lnkLogOut_Click(object sender, EventArgs e)
    {
        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
        authenticationManager.SignOut();

        Response.Redirect("~/Pages/Account/Login.aspx");
    }
}