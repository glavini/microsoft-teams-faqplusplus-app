// <copyright file="SaveConversationsViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Save conversations view model
    /// </summary>
    public class SaveConversationsViewModel
    {
        /// <summary>
        /// Gets or sets save conversations message text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Guardar conversaciones.")]
        // [StringLength(maximumLength: 10, ErrorMessage = "El texto para guardar conversaciones debe contener True o False.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Guardar conversaciones")]
        public string SaveConversationsText { get; set; }
    }
}