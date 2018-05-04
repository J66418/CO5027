/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Collections.Generic;
using System.Linq;


public class CustomerInfo
{
    public CustomerInformation GetUserInformation(string guId)
    {
        ProjectorEntities db = new ProjectorEntities();
        var info = (from x in db.CustomerInformations
                    where x.GUID == guId
                    select x).FirstOrDefault();
        return info;
    }

    public void InsertUserInfo(CustomerInformation userInformation)
    {
        ProjectorEntities db = new ProjectorEntities();
        db.CustomerInformations.Add(userInformation);
        db.SaveChanges();
    }

}