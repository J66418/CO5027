/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

public partial class Pages_Account_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        UserStore<IdentityUser> userStore = new UserStore<IdentityUser>();
        userStore.Context.Database.Connection.ConnectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["ProjectorCS"].ConnectionString;

        UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);

        //Create new user and try to store in DB.
        IdentityUser user = new IdentityUser();
        user.UserName = txtUserName.Text;
        if (txtPassword.Text == txtConfirmPassword.Text)
        {
            try
            {
                //Create user object
                //Database will be created / expanded automatically.
                IdentityResult result = manager.Create(user, txtPassword.Text);

                if (result.Succeeded)
                {
                    CustomerInformation info = new CustomerInformation
                    {
                        CustomerName = txtCustomerName.Text,
                        EMail = txtEmail.Text,
                        PhoneNumber = Convert.ToInt32(this.txtPhoneNumber.Text),
                        GUID = user.Id
                    };

                    CustomerInfo model = new CustomerInfo();
                    model.InsertUserInfo(info);

                    //Store user in DB
                    var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

                    //Set to login new user by Cookie
                    var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);

                    //Log in the new user and redirect to Product page
                    authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    litStatusMessage.Text = result.Errors.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                litStatusMessage.Text = ex.ToString();
            }
        }
        else
        {
            litStatusMessage.Text = "Passwords must match!";
        }

    }
}