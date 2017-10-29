using Samples.DomainLayer;
using System.Collections.Generic;

namespace Samples.ApplicationLayer
{
    public class UserInteractor : IUserInteractor
    {
        /// <inheritdoc />
        public IEnumerable<User> GetUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}