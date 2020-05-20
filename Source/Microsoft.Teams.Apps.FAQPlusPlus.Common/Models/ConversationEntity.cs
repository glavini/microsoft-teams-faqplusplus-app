// <copyright file="ConversationEntity.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Microsoft.Azure.Search;
    using Microsoft.WindowsAzure.Storage.Table;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents Conversation entity used for storage and retrieval.
    /// </summary>
    public class ConversationEntity : TableEntity
    {
        /// <summary>
        /// Gets or sets the unique conversation ID
        /// </summary>
        [Key]
        [JsonProperty("ConversationId")]
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user that created the conversation
        /// </summary>
        [IsSearchable]
        [JsonProperty("RequesterName")]
        public string RequesterName { get; set; }

        /// <summary>
        /// Gets or sets the user principal name (UPN) of the user that created the conversation
        /// </summary>
        [JsonProperty("RequesterUserPrincipalName")]
        public string RequesterUserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the given name of the user that created the conversation
        /// </summary>
        [JsonProperty("RequesterGivenName")]
        public string RequesterGivenName { get; set; }

        /// <summary>
        /// Gets or sets the conversation ID of the 1:1 chat with the user that created the conversation
        /// </summary>
        [JsonProperty("RequesterConversationId")]
        public string RequesterConversationId { get; set; }

        /// <summary>
        /// Gets or sets the question that the user typed
        /// </summary>
        [JsonProperty("UserQuestion")]
        public string UserQuestion { get; set; }

        /// <summary>
        /// Gets or sets the answer returned to the user from the knowledge base
        /// </summary>
        [JsonProperty("KnowledgeBaseAnswer")]
        public string KnowledgeBaseAnswer { get; set; }

        /// <summary>
        /// Gets or sets the principal question returned to the user from the knowledge base
        /// </summary>
        [JsonProperty("KnowledgeBaseQuestion")]
        public string KnowledgeBaseQuestion { get; set; }

        /// <summary>
        /// Gets or sets the source of the answer returned to the user from the knowledge base
        /// </summary>
        [JsonProperty("KnowledgeBaseAnswerSource")]
        public string KnowledgeBaseAnswerSource { get; set; }

        /// <summary>
        /// Gets or sets the score of the answer returned to the user from the knowledge base
        /// </summary>
        [JsonProperty("KnowledgeBaseScore")]
        public float KnowledgeBaseScore { get; set; }


        /// <summary>
        /// Gets timestamp from storage table
        /// </summary>
        [IsSortable]
        [JsonProperty("Timestamp")]
        public new DateTimeOffset Timestamp => base.Timestamp;
    }
}