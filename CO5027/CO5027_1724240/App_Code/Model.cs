﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class AspNetRole
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetRole()
    {
        this.AspNetUsers = new HashSet<AspNetUser>();
    }

    public string Id { get; set; }
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
}

public partial class AspNetUser
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AspNetUser()
    {
        this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
        this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
        this.AspNetRoles = new HashSet<AspNetRole>();
    }

    public string Id { get; set; }
    public string Email { get; set; }
    public bool EmailConfirmed { get; set; }
    public string PasswordHash { get; set; }
    public string SecurityStamp { get; set; }
    public string PhoneNumber { get; set; }
    public bool PhoneNumberConfirmed { get; set; }
    public bool TwoFactorEnabled { get; set; }
    public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
    public bool LockoutEnabled { get; set; }
    public int AccessFailedCount { get; set; }
    public string UserName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
}

public partial class AspNetUserClaim
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string ClaimType { get; set; }
    public string ClaimValue { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }
}

public partial class AspNetUserLogin
{
    public string LoginProvider { get; set; }
    public string ProviderKey { get; set; }
    public string UserId { get; set; }

    public virtual AspNetUser AspNetUser { get; set; }
}

public partial class CustomerInformation
{
    public int CustomerID { get; set; }
    public string GUID { get; set; }
    public string CustomerName { get; set; }
    public string EMail { get; set; }
    public Nullable<int> PhoneNumber { get; set; }
}

public partial class Product
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {
        this.ShoppingCarts = new HashSet<ShoppingCart>();
    }

    public int ProjectorID { get; set; }
    public string ProjectorName { get; set; }
    public int ProjectorTypeID { get; set; }
    public Nullable<int> ProjectorBrandID { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }

    public virtual ProductBrand ProductBrand { get; set; }
    public virtual ProductType ProductType { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
}

public partial class ProductBrand
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ProductBrand()
    {
        this.Products = new HashSet<Product>();
    }

    public int ProjectorBrandID { get; set; }
    public string ProjectorBrandName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class ProductType
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ProductType()
    {
        this.Products = new HashSet<Product>();
    }

    public int ProjectorTypeID { get; set; }
    public string ProjectorTypeName { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class ShoppingCart
{
    public int ShoppingCartID { get; set; }
    public string CustomerID { get; set; }
    public int ProjectorID { get; set; }
    public int AmountPurchased { get; set; }
    public System.DateTime DatePurchased { get; set; }
    public bool ProjectorInCart { get; set; }

    public virtual Product Product { get; set; }
}