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
        /// Gets or sets status of the conversation
        /// </summary>
        [IsSortable]
        [IsFilterable]
        [JsonProperty("Status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the conversation title
        /// </summary>
        [IsSearchable]
        [JsonProperty("Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the conversation description
        /// </summary>
        [JsonProperty("Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the created date of conversation
        /// </summary>
        [IsSortable]
        [JsonProperty("DateCreated")]
        public DateTime DateCreated { get; set; }

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
        /// Gets or sets the activity ID of the root card in the SME channel
        /// </summary>
        [JsonProperty("SmeCardActivityId")]
        public string SmeCardActivityId { get; set; }

        /// <summary>
        /// Gets or sets the conversation ID of the thread pertaining to this conversation in the SME channel
        /// </summary>
        [JsonProperty("SmeThreadConversationId")]
        public string SmeThreadConversationId { get; set; }

        /// <summary>
        /// Gets or sets the UTC date and time the conversation was last assigned
        /// </summary>
        [IsSortable]
        [JsonProperty("DateAssigned")]
        public DateTime? DateAssigned { get; set; }

        /// <summary>
        /// Gets or sets the display name of the assigned SME currently working on the conversation
        /// </summary>
        [IsSearchable]
        [IsFilterable]
        [JsonProperty("AssignedToName")]
        public string AssignedToName { get; set; }

        /// <summary>
        /// Gets or sets the AAD object ID of the assigned SME currently working on the conversation
        /// </summary>
        [JsonProperty("AssignedToObjectId")]
        public string AssignedToObjectId { get; set; }

        /// <summary>
        /// Gets or sets the UTC date and time the conversation was closed
        /// </summary>
        [IsSortable]
        [JsonProperty("DateClosed")]
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// Gets or sets the display name of the user that last modified the conversation
        /// </summary>
        [JsonProperty("LastModifiedByName")]
        public string LastModifiedByName { get; set; }

        /// <summary>
        /// Gets or sets the AAD object ID of the user that last modified the conversation
        /// </summary>
        [JsonProperty("LastModifiedByObjectId")]
        public string LastModifiedByObjectId { get; set; }

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
        /// Gets timestamp from storage table
        /// </summary>
        [IsSortable]
        [JsonProperty("Timestamp")]
        public new DateTimeOffset Timestamp => base.Timestamp;

        /// <summary>
        /// Gets or sets the message from storage table
        /// </summary>
        [JsonProperty("Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the result from storage table
        /// </summary>
        [JsonProperty("Result")]
        public string Result { get; set; }
    }
}