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


public class ShopCart
{
    public string InsertShoppingCart(ShoppingCart ShoppingCart)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            db.ShoppingCarts.Add(ShoppingCart);
            db.SaveChanges();

            return "Order was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateShoppingCart(int ShoppingCartID, ShoppingCart ShoppingCart)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();

            //Fetch object from db
            ShoppingCart p = db.ShoppingCarts.Find(ShoppingCartID);

            p.DatePurchased = ShoppingCart.DatePurchased;
            p.CustomerID = ShoppingCart.CustomerID;
            p.ProjectorID = ShoppingCart.ProjectorID;
            p.AmountPurchased = ShoppingCart.AmountPurchased;
            p.ProjectorInCart = ShoppingCart.ProjectorInCart;


            db.SaveChanges();
            return ShoppingCart.DatePurchased + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteShoppingCart(int ShoppingCartID)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            ShoppingCart ShoppingCart = db.ShoppingCarts.Find(ShoppingCartID);

            db.ShoppingCarts.Attach(ShoppingCart);
            db.ShoppingCarts.Remove(ShoppingCart);
            db.SaveChanges();

            return ShoppingCart.DatePurchased + "was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public List<ShoppingCart> GetOrdersInCart(string customerID)
    {
        ProjectorEntities db = new ProjectorEntities();
        List<ShoppingCart> orders = (from x in db.ShoppingCarts
                                     where x.CustomerID == customerID
                             && x.ProjectorInCart
                                     orderby x.DatePurchased descending
                                     select x).ToList();
        return orders;
    }

    public int GetAmountOfOrders(string customerID)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            int amountPurchased = (from x in db.ShoppingCarts
                                   where x.CustomerID == customerID
                                   && x.ProjectorInCart
                                   select x.AmountPurchased).Sum();

            return amountPurchased;
        }
        catch
        {
            return 0;
        }
    }

    public void UpdateQuantity(int ProjectorID, int quantity)
    {
        ProjectorEntities db = new ProjectorEntities();
        ShoppingCart p = db.ShoppingCarts.Find(ProjectorID);
        p.AmountPurchased = quantity;

        db.SaveChanges();
    }

    public void MarkOrdersAsPaid(List<ShoppingCart> ShoppingCarts)
    {
        ProjectorEntities db = new ProjectorEntities();

        if (ShoppingCarts != null)
        {
            foreach (ShoppingCart shoppingcart in ShoppingCarts)
            {
                ShoppingCart oldCart = db.ShoppingCarts.Find(shoppingcart.ShoppingCartID);
                oldCart.DatePurchased = DateTime.Now;
                oldCart.ProjectorInCart = false;
            }
            db.SaveChanges();
        }
    }
}
