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


public class Projector
{
    public string InsertProduct(Product Product)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            db.Products.Add(Product);
            db.SaveChanges();

            return Product.ProjectorName + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProduct(int ProjectorID, Product Product)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();

            //Fetch object from db
            Product p = db.Products.Find(ProjectorID);

            p.ProjectorName = Product.ProjectorName;

            p.Price = Product.Price;
            p.ProjectorTypeID = Product.ProjectorTypeID;
            p.ProjectorBrandID = Product.ProjectorBrandID;
            p.Description = Product.Description;
            p.Image = Product.Image;


            db.SaveChanges();
            return Product.ProjectorName + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProduct(int ProjectorID)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            Product Product = db.Products.Find(ProjectorID);

            db.Products.Attach(Product);
            db.Products.Remove(Product);
            db.SaveChanges();

            return Product.ProjectorName + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public Product GetProduct(int ProjectorID)
    {
        try
        {
            using (ProjectorEntities db = new ProjectorEntities())
            {
                Product product = db.Products.Find(ProjectorID);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Product> GetAllProducts()
    {
        try
        {
            using (ProjectorEntities db = new ProjectorEntities())
            {
                List<Product> products = (from x in db.Products
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Product> GetProductsByType(int ProjectorTypeID)
    {
        try
        {
            using (ProjectorEntities db = new ProjectorEntities())
            {
                List<Product> products = (from x in db.Products
                                          where x.ProjectorTypeID == ProjectorTypeID
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Product> GetProductsByBrand(int ProjectorBrandID)
    {
        try
        {
            using (ProjectorEntities db = new ProjectorEntities())
            {
                List<Product> products = (from x in db.Products
                                          where x.ProjectorBrandID == ProjectorBrandID
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

}
