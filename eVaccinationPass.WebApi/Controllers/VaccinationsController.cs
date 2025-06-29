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
namespace eVaccinationPass.WebApi.Controllers
{
    using TModel = eVaccinationPass.WebApi.Models.Vaccination;
    using TEntity = eVaccinationPass.Logic.Entities.Vaccination;
    using TContract = eVaccinationPass.Common.Contracts.IVaccination;
    /// <summary>
    /// Generated by the generator.
    /// </summary>
    public sealed partial class VaccinationsController(Contracts.IContextAccessor contextAccessor) : Controllers.GenericEntityController<TModel, TEntity, TContract>(contextAccessor)
    {
        /// <summary>
        /// Initializes the class (created by the generator).
        /// </summary>
        static VaccinationsController()
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
        /// Generated by the generator.
        /// </summary>
        protected override TModel ToModel(TEntity entity)
        {
            var handled = false;
            var result = new TModel();
            BeforeToModel(entity, ref result, ref handled);
            if (handled == false)
            {
                (result as TContract).CopyProperties(entity);
            }
            AfterToModel(entity, result);
            return result;
        }
        partial void BeforeToModel(TEntity entity, ref TModel outModel, ref bool handled);
        partial void AfterToModel(TEntity entity, TModel model);
        /// <summary>
        /// Generated by the generator.
        /// </summary>
        protected override TEntity ToEntity(TModel model, TEntity? entity)
        {
            var handled = false;
            var result = entity ?? new TEntity();
            BeforeToEntity(model, ref result, ref handled);
            if (handled == false)
            {
                (result as TContract).CopyProperties(model);
            }
            AfterToEntity(model, result);
            return result;
        }
        partial void BeforeToEntity(TModel model, ref TEntity outEntity, ref bool handled);
        partial void AfterToEntity(TModel model, TEntity entity);
    }
}
