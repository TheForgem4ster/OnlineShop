using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    /// <summary>
    /// Order class that contains an identification code, first name, last name, address, phone number
    /// mail, order time - with input restrictions and order details sheet
    /// Sheet of books
    /// </summary>
    public class Order
    {
        /// <summary>
        /// The BindNever attribute specifies that the model property should be excluded from 
        /// the binding mechanism.
        /// </summary>
        [BindNever]

        /// <summary>
        /// Order identification code
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Displays text with Display
        /// </summary>
        [Display(Name = "Enter your name")]// What will be displayed in the name field

        /// <summary>
        /// StringLength limits 20 characters
        /// </summary>      
        [StringLength(20)] // name length must be more than 20 characters

        /// <summary>
        /// With the Required validation attribute, that the property must be set if null
        /// output text
        /// </summary>
        [Required(ErrorMessage = "Name length must be less than 20 characters")]

        /// <summary>
        /// Customer name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Using Display we will display the text
        /// </summary>
        [Display(Name = "Enter last name")]

        /// <summary>
        /// StringLength limits 20 characters
        /// </summary> 
        [StringLength(20)]

        /// <summary>
        /// With the Required validation attribute, that the property must be set if null
        /// output text
        /// </summary>
        [Required(ErrorMessage = "last name length must be less than 20 characters")]

        /// <summary>
        /// Last name of the customer
        /// </summary>
        public string SurName { get; set; }

        /// <summary>
        /// Using Display we will display the text
        /// </summary>
        [Display(Name = "Enter address")]

        /// <summary>
        /// String Length limits 25 characters
        /// </summary> 
        [StringLength(25)]

        /// <summary>
        /// With the Required validation attribute, that the property must be set if null
        /// output text
        /// </summary>
        [Required(ErrorMessage = "address length must be less than 25 characters")]

        /// <summary>
        /// Customer address
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// Using Display we will display the text
        /// </summary>
        [Display(Name = "Enter phone number")]

        /// <summary>
        /// String Length limits 10 characters
        /// </summary> 
        [StringLength(10)] // name length must be more than 10 characters

        /// <summary>
        /// The DataType attribute allows you to provide the runtime with usage information
        /// properties - displays the phone number
        /// </summary> 
        [DataType(DataType.PhoneNumber)]

        /// <summary>
        /// With the Required validation attribute, that the property must be set if null
        /// output text
        /// </summary>
        [Required(ErrorMessage = "phone number length must be less than 10 characters")]

        /// <summary>
        /// Customer phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Using Display we will display the text
        /// </summary>
        [Display(Name = "Enter Email")]

        /// <summary>
        /// The DataType attribute allows you to provide the runtime with usage information
        /// properties - displays the email address
        /// </summary>
        [DataType(DataType.EmailAddress)]

        /// <summary>
        /// String Length limits 20 characters
        /// </summary> 
        [StringLength(20)] // name length must be more than 20 characters

        /// <summary>
        /// With the Required validation attribute, that the property must be set if null
        /// output text
        /// </summary>
        [Required(ErrorMessage = "Email length must be less than 20 characters")]

        /// <summary>
        /// Customer mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The BindNever attribute specifies that the model property should be 
        /// excluded from the binding mechanism.
        /// </summary>
        [BindNever]

        /// <summary>
        /// The ScaffoldColumn attribute indicates that this field cannot be viewed through the page
        /// (hiding)
        /// </summary>
        [ScaffoldColumn(false)]// A field that was not displayed in the source code

        /// <summary>
        /// Order completion time
        /// </summary>
        public DateTime OrderTime { get; set; }

        /// <summary>
        /// Order Details List
        /// </summary>
        public List<OrderDetail> OrderDetail { get; set; }
    }
}
