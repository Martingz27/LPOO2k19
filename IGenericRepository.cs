namespace HIS.Repo.Contracts
{
    #region Using Statement

    using System;
	using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
	using System.Threading.Tasks;
    using HIS.Data.Dto;

    #endregion

    public interface IGenericRepository<T> where T : class
	{
		/// <summary>
		/// Add new record to table
		/// </summary>
		/// <param name="entity"></param>
		void Add(T entity);

		/// <summary>
		/// Add new record to table asynchronously
		/// </summary>
		/// <param name="entity"></param>
        /// y ella e callaita
		Task AddAsync(T entity);

		/// <summary>
		/// Delete record from respective table
		/// </summary>
		/// <param name="entity"></param>
		void Delete(T entity);

        Task<IEnumerable<T>> GetAllAsync();

        /// <summary>
        /// Get all data from respective table asynchronously
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> order);

		/// <summary>
		/// Get all data whit includes from respective table
		/// </summary>
		/// <param name="order"></param>
		/// <returns></returns>
		IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		/// <summary>
		/// Get all data whit includes from respective table asynchronously
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> order, params Expression<Func<T, object>>[] includeProperties);
		/// <summary>
		/// Get all data whit includes from respective table asynchronously
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<T>> GetAllAsync(string filterBy, Expression<Func<T, object>> order, params Expression<Func<T, object>>[] includeProperties);
		/// <summary>
		/// Get all data whit includes from respective table asynchronously
		/// </summary>
		/// <returns></returns>
		Task<IEnumerable<T>> GetAllAsync(string filterBy, string order, bool ascending = true, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Get all data whit includes from respective table asynchronously
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync(string filterBy, int limit, string order, bool ascending = true, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Get all data whit includes from respective table asynchronously
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, string filterBy, string order, bool ascending = true, params Expression<Func<T, object>>[] includeProperties);
        /// <summary>
        /// Get record by primary key
        /// </summary>
        /// <returns></returns>
        T Get(int id);
		/// <summary>
		/// Get record by primary key asynchronously
		/// </summary>
		/// <returns></returns>
		Task<T> GetAsync(int id);

		/// <summary>
		/// Filter entities based on provided criteria.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		IEnumerable<T> FilterBy(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Filter entities based on provided criteria asynchronously.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> predicate);
		Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);


        Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> order);
		Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>> order, params Expression<Func<T, object>>[] includeProperties);
		Task<IEnumerable<T>> FilterByAsync(Expression<Func<T, bool>> predicate, string order = null, bool ascending = true, params Expression<Func<T, object>>[] includeProperties);

        Task<T> LastOrDefaultAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		T LastOrDefault(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

		/// <summary>
		/// Returns the number of elements
		/// </summary>
		/// <returns></returns>
		int Count();
		/// <summary>
		/// Returns the number of elements asynchronously
		/// </summary>
		/// <returns></returns>
		Task<int> CountAsync();

		/// <summary>
		/// Returns the number of elements based on provided criteria asynchronously
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<int> CountAsync(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Returns the number of elements based on provided criteria
		/// </summary>
		/// <param name="filterBy">The filter.</param>
		/// <returns></returns>
		int Count(string filterBy);


        Task<int> CountAsync(Expression<Func<T, bool>> predicate, string filterBy);

        /// <summary>
        /// Returns the number of elements based on provided criteria and groupby
        /// </summary>
        /// <param name="filterBy">The filter.</param>
        /// <param name="groupBy">The grouped</param>
        /// <returns></returns>
        int CountGrouped(string filterBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// Returns the number of elements based on provided criteria and groupby
        /// </summary>
        /// <param name="filterBy">The filter.</param>
        /// <param name="groupBy">The grouped</param>
        /// <returns></returns>
        int CountGrouped(Expression<Func<T, bool>> predicate, string filterBy, Expression<Func<T, object>> groupBy);
        /// <summary>
        /// Finds one entity based on provided criteria.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Finds one entity based on provided criteria asynchronously.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<T> FindAsync(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Finds one entity based on provided criteria whit includes.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		T Find(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		/// <summary>
		/// Finds one entity based on provided criteria whit includes asynchronously.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<T> FindAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
		Task<T> FindAsync(Expression<Func<T, bool>> predicate, string order = null, bool ascending = true, params Expression<Func<T, object>>[] includeProperties);

		/// <summary>
		/// Returns the element based on provided criteria
		/// </summary>
		/// <param name="filterBy">The filter.</param>
		/// <returns></returns>
		T Filter(string filterBy);
		/// <summary>
		/// Gets one entity or default based on matching criteria
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		T Single(Expression<Func<T, bool>> predicate);
		/// <summary>
		/// Gets one entity or default based on matching criteria asynchronously
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<T> SingleAsync(Expression<Func<T, bool>> predicate);

		/// <summary>
		/// Returns the last element.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		T GetLastRegisterNumber(Expression<Func<T, int>> predicate);

		/// <summary>
		/// Returns bool.
		/// </summary>
		/// <param name="predicate">The predicate.</param>
		/// <returns></returns>
		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get Data From Database
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        IEnumerable<T> ExecuteQuery(string filterBy, string order, string query, bool ascending = true, int pageSize = 0, int pageNumber = 0, string includeProperties = "");
        int ExecuteCountQuery(string filterBy, string query);

        /// <summary>
        /// Get Single Data From Database modificado
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        T ExecuteQuerySingle(string query, object[] parameters);

		Task<IEnumerable<T>> PagingAsync(Expression<Func<T, bool>> predicate, string order, bool ascending = true, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);
		Task<IEnumerable<T>> PagingAsync(string filterBy, Expression<Func<T, object>> order, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);
		Task<IEnumerable<T>> PagingAsync(string filterBy, string order, bool ascending = true, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);
        Task<IEnumerable<T>> PagingAsync(Expression<Func<T, bool>> predicate, string filterBy, string order, bool ascending = true, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);

        Task<IEnumerable<GenericGrouped<T>>> PagingAndGroupedAsync(string filterBy, Expression<Func<T, object>> groupBy, string order, bool ascending = true, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);
        Task<IEnumerable<GenericGrouped<T>>> PagingAndGroupedWithPredicateAsync(Expression<Func<T, bool>> predicate, string filterBy, Expression<Func<T, object>> groupBy, string order, bool ascending = true, int pageSize = 0, int pageNumber = 0, params Expression<Func<T, object>>[] includeProperties);
    }
}
