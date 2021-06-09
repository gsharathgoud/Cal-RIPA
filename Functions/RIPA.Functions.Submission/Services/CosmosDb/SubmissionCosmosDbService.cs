﻿using Microsoft.Azure.Cosmos;
using RIPA.Functions.Submission.Services.CosmosDb.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RIPA.Functions.Submission.Services.CosmosDb
{
    public class SubmissionCosmosDbService : ISubmissionCosmosDbService
    {
        private readonly Container _container;

        public SubmissionCosmosDbService(CosmosClient dbClient, string databaseName, string containerName)
        {
            _container = dbClient.GetContainer(databaseName, containerName);

        }

        public async Task AddSubmissionAsync(Models.Submission submission)
        {
            await _container.CreateItemAsync<Models.Submission>(submission, new PartitionKey(submission.Id.ToString()));
        }

        public async Task DeleteSubmissionAsync(string id)
        {
            await _container.DeleteItemAsync<Models.Submission>(id, new PartitionKey(id));
        }

        public async Task<Models.Submission> GetSubmissionAsync(string id)
        {
            try
            {
                ItemResponse<Models.Submission> response = await _container.ReadItemAsync<Models.Submission>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Models.Submission>> GetSubmissionsAsync(string queryString)
        {
            var query = _container.GetItemQueryIterator<Models.Submission>(new QueryDefinition(queryString));
            List<Models.Submission> results = new List<Models.Submission>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateSubmissionAsync(string id, Models.Submission submission)
        {
            await _container.UpsertItemAsync<Models.Submission>(submission, new PartitionKey(id));
        }
        public async Task<int> GetSubmissionsCountAsync(string queryString)
        {
            var query = _container.GetItemQueryIterator<int>(new QueryDefinition(queryString));
            List<int> results = new List<int>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results.FirstOrDefault();
        }

    }
}
