// <copyright file="HelpTabViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Help tab view model
    /// </summary>
    public class HelpTabViewModel
    {
        /// <summary>
        /// Gets or sets help tab message text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Ingrese el texto de la pestaña de ayuda.")]
        [StringLength(maximumLength: 3000, ErrorMessage = "El texto de la pestaña de ayuda debe contener hasta 3000 caracteres.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Texto de la pestaña de ayuda")]
        public string HelpTabText { get; set; }
    }
}