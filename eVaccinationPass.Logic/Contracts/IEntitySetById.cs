﻿//@CodeCopy
#if EXTERNALGUID_OFF
namespace eVaccinationPass.Logic.Contracts
{
    /// <summary>
    /// Interface for a set of entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    partial interface IEntitySet<TEntity>
    {
        /// <summary>
        /// Returns the element of type T with the identification of id.
        /// </summary>
        /// <param name = "id">The identification.</param>
        /// <returns>The element of the type T with the corresponding identification.</returns>
        ValueTask<TEntity?> GetByIdAsync(IdType id);

        /// <summary>
        /// Updates an entity in the set by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to update.</param>
        /// <param name="entity">The updated entity.</param>
        /// <returns>The updated entity, or null if the entity was not found.</returns>
        TEntity? Update(IdType id, TEntity entity);

        /// <summary>
        /// Asynchronously updates an entity in the set by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to update.</param>
        /// <param name="entity">The updated entity.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the updated entity, or null if the entity was not found.</returns>
        Task<TEntity?> UpdateAsync(IdType id, TEntity entity);

        /// <summary>
        /// Removes an entity from the set by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to remove.</param>
        /// <returns>The removed entity, or null if the entity was not found.</returns>
        TEntity? Remove(IdType id);
    }
}
#endif
