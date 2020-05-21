// <copyright file="KnowledgeBaseViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Configuration.Models
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// KnowledgeBase View Model
    /// </summary>
    public class KnowledgeBaseViewModel
    {
        /// <summary>
        /// Gets or sets knowledge base Id text box to be used in View
        /// </summary>
        [Required(ErrorMessage = "Ingrese knowledge base ID.")]
        [MinLength(1)]
        [DataType(DataType.Text)]
        [Display(Name = "Knowledge base ID")]
        [RegularExpression(@"(\S)+", ErrorMessage = "Ingrese knowledge base ID el cual no debe contener ningún espacio en blanco.")]
        public string KnowledgeBaseId { get; set; }
    }
}