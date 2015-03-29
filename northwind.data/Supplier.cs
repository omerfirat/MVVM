//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.Data
{
    using System;
    using System.Collections.Generic;using Asya.Util.Wpf.Common.Library.Entity;
    
    public partial class Supplier :  BaseEntity
    {
        public Supplier()
        {
            this.Products = new HashSet<Product>();
        }
    
        private int _supplier_ID;
    	public int Supplier_ID 
    	{ 
    		get { return _supplier_ID; } 
    		set
    		{
    			if (value != _supplier_ID) {
    				_supplier_ID = value;
    				 OnPropertyChanged("Supplier_ID");
    			}
    		} 
    	}
    
        private string _company_Name;
    	public string Company_Name 
    	{ 
    		get { return _company_Name; } 
    		set
    		{
    			if (value != _company_Name) {
    				_company_Name = value;
    				 OnPropertyChanged("Company_Name");
    			}
    		} 
    	}
    
        private string _contact_Name;
    	public string Contact_Name 
    	{ 
    		get { return _contact_Name; } 
    		set
    		{
    			if (value != _contact_Name) {
    				_contact_Name = value;
    				 OnPropertyChanged("Contact_Name");
    			}
    		} 
    	}
    
        private string _contact_Title;
    	public string Contact_Title 
    	{ 
    		get { return _contact_Title; } 
    		set
    		{
    			if (value != _contact_Title) {
    				_contact_Title = value;
    				 OnPropertyChanged("Contact_Title");
    			}
    		} 
    	}
    
        private string _address;
    	public string Address 
    	{ 
    		get { return _address; } 
    		set
    		{
    			if (value != _address) {
    				_address = value;
    				 OnPropertyChanged("Address");
    			}
    		} 
    	}
    
        private string _city;
    	public string City 
    	{ 
    		get { return _city; } 
    		set
    		{
    			if (value != _city) {
    				_city = value;
    				 OnPropertyChanged("City");
    			}
    		} 
    	}
    
        private string _region;
    	public string Region 
    	{ 
    		get { return _region; } 
    		set
    		{
    			if (value != _region) {
    				_region = value;
    				 OnPropertyChanged("Region");
    			}
    		} 
    	}
    
        private string _postal_Code;
    	public string Postal_Code 
    	{ 
    		get { return _postal_Code; } 
    		set
    		{
    			if (value != _postal_Code) {
    				_postal_Code = value;
    				 OnPropertyChanged("Postal_Code");
    			}
    		} 
    	}
    
        private string _country;
    	public string Country 
    	{ 
    		get { return _country; } 
    		set
    		{
    			if (value != _country) {
    				_country = value;
    				 OnPropertyChanged("Country");
    			}
    		} 
    	}
    
        private string _phone;
    	public string Phone 
    	{ 
    		get { return _phone; } 
    		set
    		{
    			if (value != _phone) {
    				_phone = value;
    				 OnPropertyChanged("Phone");
    			}
    		} 
    	}
    
        private string _fax;
    	public string Fax 
    	{ 
    		get { return _fax; } 
    		set
    		{
    			if (value != _fax) {
    				_fax = value;
    				 OnPropertyChanged("Fax");
    			}
    		} 
    	}
    
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
