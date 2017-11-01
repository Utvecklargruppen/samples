using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public interface IUserQueries
    {
        /// <summary>
        /// Get all users from the data store.
        /// </summary>
        IEnumerable<User> GetAllUsers();
    }
}