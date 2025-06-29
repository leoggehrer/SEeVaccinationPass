﻿//@GeneratedCode
/*****************************************************************************************
  Please note that this file is regenerated each time it is generated
  and all your changes will be overwritten in this file.
  If you still want to make changes, you can do this in 2 ways:
  
  1. Use a 'partial class name' according to the following pattern:
  
  #if GENERATEDCODE_ON
  namespace_name {
    partial class ClassName
    {
      partial void BeforeExecute(ref bool handled)
      {
        //... do something
        handled = true;
      }
    }
   }
  #endif
  
  2. Change the label //@GeneratedCode to //@CustomizedCode, for example.
     Alternatively, you can also remove the label or give it a different name.
*****************************************************************************************/
namespace eVaccinationPass.WebApi.Models
{
    using System;
    /// <summary>
    /// Generated by the generator.
    /// </summary>
    public partial class VaccinationEdit
    {
        /// <summary>
        /// Initializes the class (created by the generator).
        /// </summary>
        static VaccinationEdit()
        {
            ClassConstructing();
            ClassConstructed();
        }
        /// <summary>
        /// This method is called before the construction of the class.
        /// </summary>
        static partial void ClassConstructing();
        /// <summary>
        /// This method is called when the class is constructed.
        /// </summary>
        static partial void ClassConstructed();

        /// <summary>
        /// Initializes a new instance of the <see cref="VaccinationEdit"/> class (created by the generator.)
        /// </summary>
        public VaccinationEdit()
        {
            Constructing();

            Constructed();
        }
        /// <summary>
        /// This method is called the object is being constraucted.
        /// </summary>
        partial void Constructing();
        /// <summary>
        /// This method is called when the object is constructed.
        /// </summary>
        partial void Constructed();
        /// <summary>
        /// Property 'Date' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'Date' generated by the generator.
        /// </summary>
        public System.DateTime Date { get; set; }
        /// <summary>
        /// Property 'Vaccine' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'Vaccine' generated by the generator.
        /// </summary>
        public System.String Vaccine { get; set; } = string.Empty;
        /// <summary>
        /// Property 'SocialNumber' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'SocialNumber' generated by the generator.
        /// </summary>
        public System.String SocialNumber { get; set; } = string.Empty;
        /// <summary>
        /// Property 'FirstName' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'FirstName' generated by the generator.
        /// </summary>
        public System.String FirstName { get; set; } = string.Empty;
        /// <summary>
        /// Property 'LastName' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'LastName' generated by the generator.
        /// </summary>
        public System.String LastName { get; set; } = string.Empty;
        /// <summary>
        /// Property 'Doctor' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'Doctor' generated by the generator.
        /// </summary>
        public System.String Doctor { get; set; } = string.Empty;
        /// <summary>
        /// Property 'Note' generated by the generator.
        /// </summary>
        /// <summary>
        /// Property 'Note' generated by the generator.
        /// </summary>
        public System.String? Note { get; set; }
    }
}
