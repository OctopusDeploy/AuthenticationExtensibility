using System;
using System.ComponentModel.DataAnnotations;

namespace Octopus.Server.Extensibility.Authentication.Resources
{
    /// <summary>
    /// A command resource used for logging in.
    /// </summary>
    public class LoginCommand
    {
        /// <summary>
        /// The username to log in with.
        /// </summary>
        [Required(ErrorMessage = "Please provide a username.")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// The password to log in with.
        /// </summary>
        [Required(ErrorMessage = "Please provide a password.")]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Whether the cookie should be persistent.
        /// </summary>
        public bool RememberMe { get; set; }

        /// <summary>
        /// Encapsulated state for post successful login.
        /// </summary>
        public LoginState State { get; set; } = new LoginState();
    }
}