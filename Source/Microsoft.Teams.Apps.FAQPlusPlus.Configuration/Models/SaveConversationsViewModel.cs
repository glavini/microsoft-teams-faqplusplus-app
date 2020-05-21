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
        [Required(ErrorMessage = "Enter save conversations text.")]
        [StringLength(maximumLength: 30, ErrorMessage = "Save conversations text should contain less than 3000 characters.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Save conversations text")]
        public string SaveConversationsText { get; set; }
    }
}