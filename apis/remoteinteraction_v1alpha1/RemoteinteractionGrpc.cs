// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: proto/improbable/spatialos/remoteinteraction/v1alpha1/remoteinteraction.proto
// Original file comments:
// Provide methods to send remote commands and queries to deployments.
//
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Improbable.SpatialOS.RemoteInteraction.V1Alpha1 {
  public static partial class RemoteInteractionService
  {
    static readonly string __ServiceName = "improbable.spatialos.remoteinteraction.v1alpha1.RemoteInteractionService";

    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest> __Marshaller_EntityCommandRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse> __Marshaller_EntityCommandResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest> __Marshaller_ReserveEntityIdRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse> __Marshaller_ReserveEntityIdResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest> __Marshaller_CreateEntityRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse> __Marshaller_CreateEntityResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest> __Marshaller_DeleteEntityRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse> __Marshaller_DeleteEntityResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest> __Marshaller_EntityQueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse> __Marshaller_EntityQueryResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse> __Method_EntityCommand = new grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EntityCommand",
        __Marshaller_EntityCommandRequest,
        __Marshaller_EntityCommandResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse> __Method_ReserveEntityId = new grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReserveEntityId",
        __Marshaller_ReserveEntityIdRequest,
        __Marshaller_ReserveEntityIdResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse> __Method_CreateEntity = new grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateEntity",
        __Marshaller_CreateEntityRequest,
        __Marshaller_CreateEntityResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse> __Method_DeleteEntity = new grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteEntity",
        __Marshaller_DeleteEntityRequest,
        __Marshaller_DeleteEntityResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse> __Method_EntityQuery = new grpc::Method<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest, global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "EntityQuery",
        __Marshaller_EntityQueryRequest,
        __Marshaller_EntityQueryResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.RemoteinteractionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RemoteInteractionService</summary>
    public abstract partial class RemoteInteractionServiceBase
    {
      /// <summary>
      /// Execute an entity command.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse> EntityCommand(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Reserve an entity ID.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse> ReserveEntityId(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Create a new entity.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse> CreateEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Delete an existing entity.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse> DeleteEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Execute a one-shot query.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse> EntityQuery(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RemoteInteractionService</summary>
    public partial class RemoteInteractionServiceClient : grpc::ClientBase<RemoteInteractionServiceClient>
    {
      /// <summary>Creates a new client for RemoteInteractionService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RemoteInteractionServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RemoteInteractionService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RemoteInteractionServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RemoteInteractionServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RemoteInteractionServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Execute an entity command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse EntityCommand(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EntityCommand(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Execute an entity command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse EntityCommand(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EntityCommand, null, options, request);
      }
      /// <summary>
      /// Execute an entity command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse> EntityCommandAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EntityCommandAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Execute an entity command.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandResponse> EntityCommandAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityCommandRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EntityCommand, null, options, request);
      }
      /// <summary>
      /// Reserve an entity ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse ReserveEntityId(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReserveEntityId(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reserve an entity ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse ReserveEntityId(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReserveEntityId, null, options, request);
      }
      /// <summary>
      /// Reserve an entity ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse> ReserveEntityIdAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReserveEntityIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Reserve an entity ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdResponse> ReserveEntityIdAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.ReserveEntityIdRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReserveEntityId, null, options, request);
      }
      /// <summary>
      /// Create a new entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse CreateEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateEntity(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a new entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse CreateEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateEntity, null, options, request);
      }
      /// <summary>
      /// Create a new entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse> CreateEntityAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateEntityAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create a new entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityResponse> CreateEntityAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.CreateEntityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateEntity, null, options, request);
      }
      /// <summary>
      /// Delete an existing entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse DeleteEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteEntity(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an existing entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse DeleteEntity(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteEntity, null, options, request);
      }
      /// <summary>
      /// Delete an existing entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse> DeleteEntityAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteEntityAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Delete an existing entity.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityResponse> DeleteEntityAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.DeleteEntityRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteEntity, null, options, request);
      }
      /// <summary>
      /// Execute a one-shot query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse EntityQuery(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EntityQuery(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Execute a one-shot query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse EntityQuery(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_EntityQuery, null, options, request);
      }
      /// <summary>
      /// Execute a one-shot query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse> EntityQueryAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return EntityQueryAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Execute a one-shot query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryResponse> EntityQueryAsync(global::Improbable.SpatialOS.RemoteInteraction.V1Alpha1.EntityQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_EntityQuery, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RemoteInteractionServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RemoteInteractionServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RemoteInteractionServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_EntityCommand, serviceImpl.EntityCommand)
          .AddMethod(__Method_ReserveEntityId, serviceImpl.ReserveEntityId)
          .AddMethod(__Method_CreateEntity, serviceImpl.CreateEntity)
          .AddMethod(__Method_DeleteEntity, serviceImpl.DeleteEntity)
          .AddMethod(__Method_EntityQuery, serviceImpl.EntityQuery).Build();
    }

  }
}
#endregion
