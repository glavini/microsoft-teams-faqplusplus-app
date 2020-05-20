// <copyright file="IConversationsProvider.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Providers
{
    using System.Threading.Tasks;
    using Microsoft.Teams.Apps.FAQPlusPlus.Common.Models;

    /// <summary>
    /// Interface of Conversations provider
    /// </summary>
    public interface IConversationsProvider
    {
        /// <summary>
        /// Save or update conversation entity.
        /// </summary>
        /// <param name="conversation">Conversation received from bot based on which appropriate row will replaced or inserted in table storage</param>
        /// <returns><see cref="Task"/> that resolves successfully if the data was saved successfully.</returns>
        Task SaveOrUpdateConversationAsync(ConversationEntity conversation);

        /// <summary>
        /// Get already saved entity detail from storage table
        /// </summary>
        /// <param name="conversationId">conversation id received from bot based on which appropriate row data will be fetched</param>
        /// <returns><see cref="Task"/> Already saved entity detail</returns>
        Task<ConversationEntity> GetConversationAsync(string conversationId);
    }
}
