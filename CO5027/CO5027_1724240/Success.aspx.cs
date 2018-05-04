/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

public partial class Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<ShoppingCart> shoppingcarts = (List<ShoppingCart>)Session[User.Identity.GetUserId()];

        ShopCart model = new ShopCart();
        model.MarkOrdersAsPaid(shoppingcarts);

        Session[User.Identity.GetUserId()] = null;
    }
}