/*!
 * Author: Michiel Wouters
 * Source: Create a webshop with Asp.Net (https://www.dropbox.com/s/7u3ilg68cuoyuii/GarageManager%20-%207%20-%20Source.rar?dl=0)
 * Video Tutorial: Create a webshop with Asp.Net (https://www.youtube.com/watch?v=sXS2lX7XdOs&list=PLi5N5AdsklLbrs_7GAOAmmgnbKT042-U9)
 * Copyright 2014
 */

using System;
using System.Collections;
using System.IO;

public partial class Pages_Admin_ManageProjector : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetImages();

            //Check if the url contains an ID parameter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["ProjectorID"]))
            {
                int ProjectorID = Convert.ToInt32(Request.QueryString["ProjectorID"]);
                FillPage(ProjectorID);
            }
        }
    }

    private Product CreateProduct()
    {
        Product p = new Product();

        p.ProjectorName = txtProjectorModel.Text;
        p.ProjectorTypeID = Convert.ToInt32(ddlProjectorType.SelectedValue);
        p.ProjectorBrandID = Convert.ToInt32(ddlProjectorBrand.SelectedValue);
        p.Price = Convert.ToDecimal(txtPrice.Text);
        p.Description = txtDescription.Text;
        p.Image = ddlImage.SelectedValue;

        return p;
    }

    private void FillPage(int ProjectorID)
    {
        //Get selected Projector from DB
        Projector Projector = new Projector();
        Product Product = Projector.GetProduct(ProjectorID);

        //Fill textboxes
        txtDescription.Text = Product.Description;
        txtProjectorModel.Text = Product.ProjectorName;
        txtPrice.Text = Product.Price.ToString();

        //set dropdownlist values
        ddlImage.SelectedValue = Product.Image;
        ddlProjectorType.SelectedValue = Product.ProjectorTypeID.ToString();
    }

    private void FillForm(int ProjectorID)
    {
        try
        {
            Projector Projector = new Projector();
            Product Product = Projector.GetProduct(ProjectorID);

            //Fill textboxes
            txtDescription.Text = Product.Description;
            txtProjectorModel.Text = Product.ProjectorName;
            txtPrice.Text = Product.Price.ToString();

            //set dropdownlist values
            ddlImage.SelectedValue = Product.Image;
            ddlProjectorType.SelectedValue = Product.ProjectorTypeID.ToString();
        }
        catch (Exception ex)
        {
            lblResult.Text = ex.ToString();
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Projector Projector = new Projector();
        Product Product = CreateProduct();

        //Check if the url contains an ID parameter
        if (!String.IsNullOrWhiteSpace(Request.QueryString["ProjectorID"]))
        {
            //ID exists -> Update existing row
            int ProjectorID = Convert.ToInt32(Request.QueryString["ProjectorID"]);
            lblResult.Text = Projector.UpdateProduct(ProjectorID, Product);
        }
        else
        {
            //ID does not exist -> Create a new row
            lblResult.Text = Projector.InsertProduct(Product);
        }
    }

    private void GetImages()
    {
        try
        {
            //Get all filepaths
            string[] images = Directory.GetFiles(Server.MapPath("~/Images/Product/"));

            //Get all filenames and add them to an arraylist
            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            //Set the arraylist as the dropdown's view datasource and refresh
            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();
        }
        catch (Exception e)
        {
            lblResult.Text = e.ToString();
        }
    }
}