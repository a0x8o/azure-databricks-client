﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Net.Http;

namespace Microsoft.Azure.Databricks.Client
{
    public class SQLApiClient : ApiClient, ISQLApi
    {
        public SQLApiClient(HttpClient httpClient) : base(httpClient)
        {
            this.StatementExecution = new StatementExecutionApiClient(httpClient);
            this.Warehouse = new WarehouseApiClient(httpClient);
        }

        public IStatementExecutionApi StatementExecution { get; }

        public IWarehouseApi Warehouse { get; }
    }
}
