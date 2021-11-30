// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.DeviceUpdate.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    /// <summary> A class representing collection of PrivateEndpointConnectionProxy and their operations over its parent. </summary>
    public partial class PrivateEndpointConnectionProxyCollection : ArmCollection, IEnumerable<PrivateEndpointConnectionProxy>, IAsyncEnumerable<PrivateEndpointConnectionProxy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly PrivateEndpointConnectionProxiesRestOperations _privateEndpointConnectionProxiesRestClient;

        /// <summary> Initializes a new instance of the <see cref="PrivateEndpointConnectionProxyCollection"/> class for mocking. </summary>
        protected PrivateEndpointConnectionProxyCollection()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionProxyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal PrivateEndpointConnectionProxyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _privateEndpointConnectionProxiesRestClient = new PrivateEndpointConnectionProxiesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DeviceUpdateAccount.ResourceType;

        // Collection level operations.

        /// <summary> (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="privateEndpointConnectionProxy"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="privateEndpointConnectionProxy"/> is null. </exception>
        public virtual PrivateEndpointConnectionProxyCreateOrUpdateOperation CreateOrUpdate(string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData privateEndpointConnectionProxy, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxy == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxy));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxiesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, privateEndpointConnectionProxy, cancellationToken);
                var operation = new PrivateEndpointConnectionProxyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _privateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, privateEndpointConnectionProxy).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Creates or updates the specified private endpoint connection proxy resource associated with the device update account. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="privateEndpointConnectionProxy"> The parameters for creating a private endpoint connection proxy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> or <paramref name="privateEndpointConnectionProxy"/> is null. </exception>
        public async virtual Task<PrivateEndpointConnectionProxyCreateOrUpdateOperation> CreateOrUpdateAsync(string privateEndpointConnectionProxyId, PrivateEndpointConnectionProxyData privateEndpointConnectionProxy, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }
            if (privateEndpointConnectionProxy == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxy));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxiesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, privateEndpointConnectionProxy, cancellationToken).ConfigureAwait(false);
                var operation = new PrivateEndpointConnectionProxyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _privateEndpointConnectionProxiesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, privateEndpointConnectionProxy).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionProxy> Get(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxiesRestClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new PrivateEndpointConnectionProxy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) Get the specified private endpoint connection proxy associated with the device update account. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public async virtual Task<Response<PrivateEndpointConnectionProxy>> GetAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.Get");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxiesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new PrivateEndpointConnectionProxy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<PrivateEndpointConnectionProxy> GetIfExists(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _privateEndpointConnectionProxiesRestClient.Get(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<PrivateEndpointConnectionProxy>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateEndpointConnectionProxy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public async virtual Task<Response<PrivateEndpointConnectionProxy>> GetIfExistsAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _privateEndpointConnectionProxiesRestClient.GetAsync(Id.ResourceGroupName, Id.Name, privateEndpointConnectionProxyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<PrivateEndpointConnectionProxy>(null, response.GetRawResponse())
                    : Response.FromValue(new PrivateEndpointConnectionProxy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(privateEndpointConnectionProxyId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="privateEndpointConnectionProxyId"> The ID of the private endpoint connection proxy object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionProxyId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string privateEndpointConnectionProxyId, CancellationToken cancellationToken = default)
        {
            if (privateEndpointConnectionProxyId == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionProxyId));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(privateEndpointConnectionProxyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PrivateEndpointConnectionProxy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PrivateEndpointConnectionProxy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<PrivateEndpointConnectionProxy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _privateEndpointConnectionProxiesRestClient.ListByAccount(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionProxy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary> (INTERNAL - DO NOT USE) List all private endpoint connection proxies in a device update account. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PrivateEndpointConnectionProxy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PrivateEndpointConnectionProxy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PrivateEndpointConnectionProxy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionProxyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _privateEndpointConnectionProxiesRestClient.ListByAccountAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new PrivateEndpointConnectionProxy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<PrivateEndpointConnectionProxy> IEnumerable<PrivateEndpointConnectionProxy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<PrivateEndpointConnectionProxy> IAsyncEnumerable<PrivateEndpointConnectionProxy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, PrivateEndpointConnectionProxy, PrivateEndpointConnectionProxyData> Construct() { }
    }
}
