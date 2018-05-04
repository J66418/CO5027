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


public class ProjectorType
{
    public string InsertProductType(ProductType ProductType)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            db.ProductTypes.Add(ProductType);
            db.SaveChanges();

            return ProductType.ProjectorTypeName + " was succesfully inserted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProductType(int ProjectorTypeID, ProductType ProductType)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();

            //Fetch object from db
            ProductType p = db.ProductTypes.Find(ProjectorTypeID);

            p.ProjectorTypeName = ProductType.ProjectorTypeName;

            db.SaveChanges();
            return ProductType.ProjectorTypeName + " was succesfully updated";

        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProductType(int ProjectorTypeID)
    {
        try
        {
            ProjectorEntities db = new ProjectorEntities();
            ProductType ProductType = db.ProductTypes.Find(ProjectorTypeID);

            db.ProductTypes.Attach(ProductType);
            db.ProductTypes.Remove(ProductType);
            db.SaveChanges();

            return ProductType.ProjectorTypeName + " was succesfully deleted";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}