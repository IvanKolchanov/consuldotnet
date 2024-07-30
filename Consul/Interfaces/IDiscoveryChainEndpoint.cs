// -----------------------------------------------------------------------
//  <copyright file="IDiscoveryChainEndpoint.cs" company="PlayFab Inc">
//    Copyright 2015 PlayFab Inc.
//    Copyright 2020 G-Research Limited
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//  </copyright>
// -----------------------------------------------------------------------

using System.Threading;
using System.Threading.Tasks;
using Consul.Filtering;

namespace Consul
{
    /// <summary>
    /// The interface for the Discovery Chain API Endpoints
    /// </summary>
    public interface IDiscoveryChainEndpoint
    {
        Task<QueryResult<CompiledDiscoveryChain>> Get(string name, QueryOptions q, CancellationToken ct = default);
        Task<QueryResult<CompiledDiscoveryChain>> Get(string name, CancellationToken ct = default);
        Task<WriteResult<CompiledDiscoveryChain>> Get(string name, DiscoveryChainOptions options, WriteOptions q, CancellationToken ct = default);
        Task<WriteResult<CompiledDiscoveryChain>> Get(string name, DiscoveryChainOptions options, CancellationToken ct = default);
    }
}