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



public class ProjectorBrand
{
    public string InsertProductBrand(ProductBrand ProductBrand)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            db.ProductBrands.Add(ProductBrand);
            db.SaveChanges();

            return ProductBrand.ProjectorBrandName + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProductBrand(int ProjectorBrandID, ProductBrand ProductBrand)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();

            //Fetch object from db
            ProductBrand p = db.ProductBrands.Find(ProjectorBrandID);

            p.ProjectorBrandName = ProductBrand.ProjectorBrandName;

            db.SaveChanges();
            return ProductBrand.ProjectorBrandName + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProductBrand(int ProjectorBrandID)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            ProductBrand ProductBrand = db.ProductBrands.Find(ProjectorBrandID);

            db.ProductBrands.Attach(ProductBrand);
            db.ProductBrands.Remove(ProductBrand);
            db.SaveChanges();

            return ProductBrand.ProjectorBrandName + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}