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
        [Display(Name = "Guardar conversaciones")]
        public bool SaveConversationsText { get; set; }
    }
}