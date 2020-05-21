// <copyright file="WelcomeMessageViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Welcome message view model
    /// </summary>
    public class WelcomeMessageViewModel
    {
        /// <summary>
        /// Gets or sets welcome message text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Ingrese un mensaje de bienvenida.")]
        [StringLength(maximumLength: 300, ErrorMessage = "Ingrese el mensaje de bienvenida que debe contener hasta 300 caracteres.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Mensaje de bienvenida")]
        public string WelcomeMessage { get; set; }
    }
}