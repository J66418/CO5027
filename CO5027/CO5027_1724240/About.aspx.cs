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
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net.Mail;
using System.Net;

public partial class About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            //Create the msg object to be sent
            MailMessage msg = new MailMessage();
            //Add your email address to the recipients
            msg.To.Add("projectinglife.brunei@gmail.com");
            //Configure the address we are sending the mail from
            MailAddress address = new MailAddress("projectinglife.brunei@gmail.com");
            msg.From = address;
            //Append their name in the beginning of the subject
            msg.Subject = txtName.Text + " : " + txtEmail.Text + " : " + ddlSubject.Text;
            msg.Body = txtMessage.Text;

            //Configure an SmtpClient to send the mail.
            SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
            server.EnableSsl = true; //only enable this if your provider requires it
            //Setup credentials to login to our sender email address ("UserName", "Password")
            NetworkCredential credentials = new NetworkCredential("projectinglife.brunei@gmail.com", "p@55word2018");
            server.Credentials = credentials;

            //Send the msg
            server.Send(msg);

            //Display some feedback to the user to let them know it was sent
            lblResult.Text = "Your message was sent!";

            //Clear the form
            txtName.Text = "";
            txtMessage.Text = "";
        }
        catch
        {
            //If the message failed at some point, let the user know
            lblResult.Text = "Your message failed to send, please try again.";
        }
    }
}
