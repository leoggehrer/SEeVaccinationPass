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
namespace eVaccinationPass.Logic.Contracts.Account
{
    /// <summary>
    /// Generated by the generator.
    /// </summary>
    internal partial interface IUser : CommonContracts.IVersionable
    {
        IdType IdentityId { get; set; }
        System.String FirstName { get; set; }
        System.String LastName { get; set; }
        /// <summary>
        /// Copies the properties of another object to this instance.
        /// </summary>
        /// <param name="other">The object to copy the properties from.</param>
        void CopyProperties(IUser other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                ((CommonContracts.IVersionable)this).CopyProperties(other);
                IdentityId = other.IdentityId;
                FirstName = other.FirstName;
                LastName = other.LastName;
            }
            AfterCopyProperties(other);
        }
        /// <summary>
        /// This method is called before copying the properties of another object to the current instance.
        /// </summary>
        /// <param name="other">The object to copy the properties from.</param>
        /// <param name="handled">A boolean value that indicates whether the method has been handled.</param>
        partial void BeforeCopyProperties(IUser other, ref bool handled);
        /// <summary>
        /// This method is called after copying properties from another instance of the class.
        /// </summary>
        /// <param name="other">The other instance of the class from which properties were copied.</param>
        partial void AfterCopyProperties(IUser other);
    }
}
