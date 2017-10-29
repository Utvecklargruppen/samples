using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    /// <summary>
    /// The user interactor interface.
    /// </summary>
    public interface IUserInteractor
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        IEnumerable<User> GetUsers();
    }
}