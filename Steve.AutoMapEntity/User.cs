

namespace Steve.AutoMapEntity
{
    /// <summary>
    /// This class represents a user.
    /// </summary>
    public class User
    {
        /// <summary>
        /// The unique identifier for the user.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// The name of the user.
        /// </summary>
        public string Name { get; set; } = "Steve";

        /// <summary>
        /// The email address of the user.
        /// </summary>
        public string Email { get; set; } = "mrsteve.bang@gmail.com";

        /// <summary>
        /// The first name of the user.
        /// </summary>
        public string FirstName { get; set; } = "Steve";

        /// <summary>
        /// The last name of the user.
        /// </summary>
        public string LastName { get; set; } = "Bang";
    }
}
