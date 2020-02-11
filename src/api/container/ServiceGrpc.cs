// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: container/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NeoFS.API.Container {
  /// <summary>
  /// Container service provides API for manipulating with the container.
  /// </summary>
  public static partial class Service
  {
    static readonly string __ServiceName = "container.Service";

    static readonly grpc::Marshaller<global::NeoFS.API.Container.PutRequest> __Marshaller_container_PutRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.PutRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.PutResponse> __Marshaller_container_PutResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.PutResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.DeleteRequest> __Marshaller_container_DeleteRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.DeleteRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.DeleteResponse> __Marshaller_container_DeleteResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.DeleteResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.GetRequest> __Marshaller_container_GetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.GetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.GetResponse> __Marshaller_container_GetResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.GetResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.ListRequest> __Marshaller_container_ListRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.ListRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Container.ListResponse> __Marshaller_container_ListResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Container.ListResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::NeoFS.API.Container.PutRequest, global::NeoFS.API.Container.PutResponse> __Method_Put = new grpc::Method<global::NeoFS.API.Container.PutRequest, global::NeoFS.API.Container.PutResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Put",
        __Marshaller_container_PutRequest,
        __Marshaller_container_PutResponse);

    static readonly grpc::Method<global::NeoFS.API.Container.DeleteRequest, global::NeoFS.API.Container.DeleteResponse> __Method_Delete = new grpc::Method<global::NeoFS.API.Container.DeleteRequest, global::NeoFS.API.Container.DeleteResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_container_DeleteRequest,
        __Marshaller_container_DeleteResponse);

    static readonly grpc::Method<global::NeoFS.API.Container.GetRequest, global::NeoFS.API.Container.GetResponse> __Method_Get = new grpc::Method<global::NeoFS.API.Container.GetRequest, global::NeoFS.API.Container.GetResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_container_GetRequest,
        __Marshaller_container_GetResponse);

    static readonly grpc::Method<global::NeoFS.API.Container.ListRequest, global::NeoFS.API.Container.ListResponse> __Method_List = new grpc::Method<global::NeoFS.API.Container.ListRequest, global::NeoFS.API.Container.ListResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "List",
        __Marshaller_container_ListRequest,
        __Marshaller_container_ListResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NeoFS.API.Container.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Service</summary>
    public partial class ServiceClient : grpc::ClientBase<ServiceClient>
    {
      /// <summary>Creates a new client for Service</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Service that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Put request proposes container to the inner ring nodes. They will
      /// accept new container if user has enough deposit. All containers
      /// are accepted by the consensus, therefore it is asynchronous process.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.PutResponse Put(global::NeoFS.API.Container.PutRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Put(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Put request proposes container to the inner ring nodes. They will
      /// accept new container if user has enough deposit. All containers
      /// are accepted by the consensus, therefore it is asynchronous process.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.PutResponse Put(global::NeoFS.API.Container.PutRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Put, null, options, request);
      }
      /// <summary>
      /// Put request proposes container to the inner ring nodes. They will
      /// accept new container if user has enough deposit. All containers
      /// are accepted by the consensus, therefore it is asynchronous process.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.PutResponse> PutAsync(global::NeoFS.API.Container.PutRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PutAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Put request proposes container to the inner ring nodes. They will
      /// accept new container if user has enough deposit. All containers
      /// are accepted by the consensus, therefore it is asynchronous process.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.PutResponse> PutAsync(global::NeoFS.API.Container.PutRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Put, null, options, request);
      }
      /// <summary>
      /// Delete container removes it from the inner ring container storage. It
      /// also asynchronous process done by consensus.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.DeleteResponse Delete(global::NeoFS.API.Container.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete container removes it from the inner ring container storage. It
      /// also asynchronous process done by consensus.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.DeleteResponse Delete(global::NeoFS.API.Container.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Delete container removes it from the inner ring container storage. It
      /// also asynchronous process done by consensus.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.DeleteResponse> DeleteAsync(global::NeoFS.API.Container.DeleteRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete container removes it from the inner ring container storage. It
      /// also asynchronous process done by consensus.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.DeleteResponse> DeleteAsync(global::NeoFS.API.Container.DeleteRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>
      /// Get container returns container instance
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.GetResponse Get(global::NeoFS.API.Container.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get container returns container instance
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.GetResponse Get(global::NeoFS.API.Container.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// Get container returns container instance
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.GetResponse> GetAsync(global::NeoFS.API.Container.GetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get container returns container instance
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.GetResponse> GetAsync(global::NeoFS.API.Container.GetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      /// <summary>
      /// List returns all user's containers
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.ListResponse List(global::NeoFS.API.Container.ListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return List(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List returns all user's containers
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::NeoFS.API.Container.ListResponse List(global::NeoFS.API.Container.ListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>
      /// List returns all user's containers
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.ListResponse> ListAsync(global::NeoFS.API.Container.ListRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// List returns all user's containers
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::NeoFS.API.Container.ListResponse> ListAsync(global::NeoFS.API.Container.ListRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_List, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServiceClient(configuration);
      }
    }

  }
}
#endregion