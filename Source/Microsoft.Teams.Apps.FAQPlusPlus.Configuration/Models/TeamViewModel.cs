// <copyright file="TeamViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Team view model
    /// </summary>
    public class TeamViewModel
    {
        /// <summary>
        /// Gets or sets team Id textbox to be used in View
        /// </summary>
        [Required(ErrorMessage = "Ingrese Team ID.")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name ="Team ID")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Ingrese Team ID el cual no debe contener ningún espacio en blanco.")]
        public string TeamId { get; set; }
    }
}