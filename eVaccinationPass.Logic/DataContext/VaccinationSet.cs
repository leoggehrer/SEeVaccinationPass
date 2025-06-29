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
namespace eVaccinationPass.Logic.DataContext
{
    using TEntity = Entities.Vaccination;
    using TContract = eVaccinationPass.Common.Contracts.IVaccination;
    /// <summary>
    /// Generated by the generator.
    /// </summary>
    internal sealed partial class VaccinationSet : EntitySet<TEntity>, Contracts.IVaccinationSet
    {
        /// <summary>
        /// Initializes the class (created by the generator).
        /// </summary>
        static VaccinationSet()
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
        /// Initializes a new instance of the <see cref="VaccinationSet"/> class (created by the generator.)
        /// </summary>
        public VaccinationSet(ProjectDbContext context, DbSet<TEntity> dbSet)
         : base(context, dbSet)
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
        /// Copies the properties from the source <see cref="TEntity"/> to the target <see cref="TEntity"/>.
        /// </summary>
        /// <param name="target">The target <see cref="TEntity"/>.</param>
        /// <param name="source">The source <see cref="TEntity"/>.</param>
        protected override void CopyProperties(TEntity target, TEntity source)
        {
            target.CheckArgument(nameof(target));
            source.CheckArgument(nameof(source));
            bool handled = false;
            BeforeCopyProperties(target, source, ref handled);
            if (handled == false)
            {
                if (target is TContract itarget
                    && source is TContract isource)
                {
                    itarget.CopyProperties(isource);
                }
            }
            AfterCopyProperties(target, source);
        }
        /// <summary>
        /// This method is called before copying the properties of another object to the current instance.
        /// </summary>
        /// <param name="target">The object to copy the properties from.</param>
        /// <param name="source">The object in which the properties are to be copied.</param>
        /// <param name="handled">A boolean value that indicates whether the method has been handled.</param>
        partial void BeforeCopyProperties(TEntity target, TEntity source, ref bool handled);
        /// <summary>
        /// This method is called after copying properties from another instance of the class.
        /// </summary>
        /// <param name="target">The object to copy the properties from.</param>
        /// <param name="source">The object in which the properties are to be copied.</param>
        partial void AfterCopyProperties(TEntity target, TEntity source);
    }
}
