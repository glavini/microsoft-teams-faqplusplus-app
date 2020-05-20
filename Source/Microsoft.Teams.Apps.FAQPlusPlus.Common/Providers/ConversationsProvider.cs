// <copyright file="ConversationsProvider.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
namespace Microsoft.Teams.Apps.FAQPlusPlus.Common.Providers
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.Teams.Apps.FAQPlusPlus.Common.Exceptions;
    using Microsoft.Teams.Apps.FAQPlusPlus.Common.Models;
    using Microsoft.WindowsAzure.Storage;
    using Microsoft.WindowsAzure.Storage.Table;

    /// <summary>
    /// ConversationProviders which will help in fetching and storing information in storage table.
    /// </summary>
    public class ConversationsProvider : IConversationsProvider
    {
        private const string PartitionKey = "ConversationInfo";

        private readonly Lazy<Task> initializeTask;
        private CloudTable conversationCloudTable;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationsProvider"/> class.
        /// </summary>
        /// <param name="connectionString">connection string of storage provided by DI</param>
        public ConversationsProvider(string connectionString)
        {
            this.initializeTask = new Lazy<Task>(() => this.InitializeAsync(connectionString));
        }

        /// <summary>
        /// Store or update conversation entity in table storage
        /// </summary>
        /// <param name="conversation">conversationEntity.</param>
        /// <returns><see cref="Task"/> that represents configuration entity is saved or updated.</returns>
        public Task SaveOrUpdateConversationAsync(ConversationEntity conversation)
        {
            conversation.PartitionKey = PartitionKey;
            conversation.RowKey = conversation.ConversationId;

            // if (conversation.Status > (int)ConversationState.MaxValue)
            // {
            //     throw new ConversationValidationException($"The conversation status ({conversation.Status}) is not valid.");
            // }

            return this.StoreOrUpdateConversationEntityAsync(conversation);
        }

        /// <inheritdoc/>
        public async Task<ConversationEntity> GetConversationAsync(string conversationId)
        {
            await this.EnsureInitializedAsync();

            var searchOperation = TableOperation.Retrieve<ConversationEntity>(PartitionKey, conversationId);
            var searchResult = await this.conversationCloudTable.ExecuteAsync(searchOperation);

            return (ConversationEntity)searchResult.Result;
        }

        /// <summary>
        /// Store or update conversation entity in table storage
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <returns><see cref="Task"/> that represents configuration entity is saved or updated.</returns>
        private async Task<TableResult> StoreOrUpdateConversationEntityAsync(ConversationEntity entity)
        {
            await this.EnsureInitializedAsync();
            TableOperation addOrUpdateOperation = TableOperation.InsertOrReplace(entity);
            return await this.conversationCloudTable.ExecuteAsync(addOrUpdateOperation);
        }

        /// <summary>
        /// Create conversations table if it doesnt exists
        /// </summary>
        /// <param name="connectionString">storage account connection string</param>
        /// <returns><see cref="Task"/> representing the asynchronous operation task which represents table is created if its not existing.</returns>
        private async Task InitializeAsync(string connectionString)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connectionString);
            CloudTableClient cloudTableClient = storageAccount.CreateCloudTableClient();
            this.conversationCloudTable = cloudTableClient.GetTableReference(StorageInfo.ConversationTableName);

            await this.conversationCloudTable.CreateIfNotExistsAsync();
        }

        /// <summary>
        /// Initialization of InitializeAsync method which will help in creating table
        /// </summary>
        /// <returns>Task</returns>
        private async Task EnsureInitializedAsync()
        {
            await this.initializeTask.Value;
        }
    }
}
