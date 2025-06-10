﻿//@CodeCopy
using eVaccinationPass.Logic.Contracts;
using eVaccinationPass.WebApi.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Linq.Dynamic.Core.Exceptions;

namespace eVaccinationPass.WebApi.Controllers
{
    /// <summary>
    /// A generic controller for handling CRUD operations.
    /// </summary>
    /// <typeparam name="TModel">The type of the model.</typeparam>
    /// <typeparam name="TView">The type of the entity.</typeparam>
    /// <typeparam name="TContract">The type of the interface.</typeparam>
    [Route("api/[controller]")]
    [ApiController]
    public abstract partial class GenericViewController<TModel, TView, TContract> : ApiControllerBase, IGenericViewController<TModel, TContract> where TContract : CommonContracts.IViewObject
        where TModel : CommonModels.ViewModelObject, TContract, new()
        where TView : Logic.Entities.ViewObject, TContract, new()
    {
        #region fields
        private readonly IContextAccessor _contextAccessor;
        #endregion fields

        #region properties
        /// <summary>
        /// Gets the max count.
        /// </summary>
        protected virtual int MaxCount { get; } = 500;
        /// <summary>
        /// Gets the context accessor.
        /// </summary>
        protected IContextAccessor ContextAccessor
        {
            get
            {
                OnReadContextAccessor(_contextAccessor);
                return _contextAccessor;
            }
        }
        partial void OnReadContextAccessor(IContextAccessor contextAccessor);

        /// <summary>
        /// Gets the context.
        /// </summary>
        protected virtual IContext Context => ContextAccessor.GetContext();
        /// <summary>
        /// Gets the DbSet.
        /// </summary>
        protected virtual IViewSet<TView> ViewSet => ContextAccessor.GetViewSet<TView>() ?? throw new Exception($"Invalid DbSet<{typeof(TView)}>");
        /// <summary>
        /// Gets the IQueriable<TEntity>.
        /// </summary>
        protected virtual IQueryable<TView> NoTrackingSet => ViewSet.AsNoTrackingSet();
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericEntityController{TModel, TEntity, TContract}"/> class.
        /// </summary>
        /// <param name="contextAccessor">The context accessor.</param>
        public GenericViewController(IContextAccessor contextAccessor)
        {
            Constructing();
            BeforeSetContextAccessor(contextAccessor);
            _contextAccessor = contextAccessor;
            AfterSetContextAccessor(ContextAccessor);
            Constructed();
        }
        /// <summary>
        /// This method is called the object is being constraucted.
        /// </summary>
        partial void Constructing();

        /// <summary>
        /// This method is called before setting the context accessor.
        /// </summary>
        /// <param name="contextAccessor">The context accessor.</param>
        partial void BeforeSetContextAccessor(IContextAccessor contextAccessor);
        /// <summary>
        /// This method is called after setting the context accessor.
        /// </summary>
        /// <param name="contextAccessor">The context accessor.</param>
        partial void AfterSetContextAccessor(IContextAccessor contextAccessor);
        /// <summary>
        /// This method is called when the object is constructed.
        /// </summary>
        partial void Constructed();
        #endregion constructors

        /// <summary>
        /// Converts an entity to a model.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>The model.</returns>
        protected abstract TModel ToModel(TView entity);

        [HttpGet("count")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult> CountAsync()
        {
            var result = await ViewSet.CountAsync();

            return Ok(result);
        }

        /// <summary>
        /// Gets all models.
        /// </summary>
        /// <returns>A list of models.</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult<IEnumerable<TModel>>> GetAsync()
        {
            var authHeader = HttpContext.Request.Headers.Authorization;

            var query = await NoTrackingSet.AsNoTracking().Take(MaxCount).ToArrayAsync();
            var result = query.Select(e => ToModel(e));

            return Ok(result);
        }

        /// <summary>
        /// Queries models based on a predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns>A list of models.</returns>
        [HttpPost("query")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult<IEnumerable<TModel>>> QueryAsync([FromBody]Models.QueryParams queryParams)
        {
            if (string.IsNullOrWhiteSpace(queryParams.Filter))
                return BadRequest("The filter printout must not be empty.");

            try
            {
                var query = await NoTrackingSet.AsNoTracking()
                                          .Where(ParsingConfig, queryParams.Filter, queryParams.Values)
                                          .Take(MaxCount)
                                          .ToArrayAsync();
                var result = query.Select(e => ToModel(e)).ToArray();

                return Ok(result);
            }
            catch (ParseException ex)
            {
                return BadRequest($"Invalid filter expression: {ex.Message}");
            }
        }
    }
}
