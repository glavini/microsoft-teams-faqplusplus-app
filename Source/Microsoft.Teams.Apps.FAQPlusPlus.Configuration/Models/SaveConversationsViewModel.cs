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
        /// Gets or sets save conversations text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Enter a save conversations.")]
        [StringLength(maximumLength: 300, ErrorMessage = "Enter save conversations which should contain True or False.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Save Conversations")]
        public string SaveConversations { get; set; }
    }
}