// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: proto/improbable/spatialos/playerauth/v2alpha1/player_auth.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Improbable.SpatialOS.PlayerAuth.V2Alpha1 {
  public static partial class PlayerAuthService
  {
    static readonly string __ServiceName = "improbable.spatialos.playerauth.v2alpha1.PlayerAuthService";

    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest> __Marshaller_CreateLoginTokenRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse> __Marshaller_CreateLoginTokenResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest> __Marshaller_CreatePlayerIdentityTokenRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse> __Marshaller_CreatePlayerIdentityTokenResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest> __Marshaller_DecodePlayerIdentityTokenRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse> __Marshaller_DecodePlayerIdentityTokenResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse> __Method_CreateLoginToken = new grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateLoginToken",
        __Marshaller_CreateLoginTokenRequest,
        __Marshaller_CreateLoginTokenResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse> __Method_CreatePlayerIdentityToken = new grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreatePlayerIdentityToken",
        __Marshaller_CreatePlayerIdentityTokenRequest,
        __Marshaller_CreatePlayerIdentityTokenResponse);

    static readonly grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse> __Method_DecodePlayerIdentityToken = new grpc::Method<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest, global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DecodePlayerIdentityToken",
        __Marshaller_DecodePlayerIdentityTokenRequest,
        __Marshaller_DecodePlayerIdentityTokenResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.PlayerAuthReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of PlayerAuthService</summary>
    public abstract partial class PlayerAuthServiceBase
    {
      /// <summary>
      /// Creates a LoginToken (LT) for a given user, project and deployment.
      ///
      /// This grants the user access to a given deployment.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse> CreateLoginToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a PlayerIdentityToken (PIT) for a given user and project.
      ///
      /// This guarantees player identity in the context of a project.
      ///
      /// Invalid fields will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse> CreatePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Decodes a PlayerIdentityToken (PIT).
      ///
      /// Tokens that cannot be verified will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse> DecodePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for PlayerAuthService</summary>
    public partial class PlayerAuthServiceClient : grpc::ClientBase<PlayerAuthServiceClient>
    {
      /// <summary>Creates a new client for PlayerAuthService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public PlayerAuthServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PlayerAuthService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public PlayerAuthServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected PlayerAuthServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected PlayerAuthServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a LoginToken (LT) for a given user, project and deployment.
      ///
      /// This grants the user access to a given deployment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse CreateLoginToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLoginToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a LoginToken (LT) for a given user, project and deployment.
      ///
      /// This grants the user access to a given deployment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse CreateLoginToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateLoginToken, null, options, request);
      }
      /// <summary>
      /// Creates a LoginToken (LT) for a given user, project and deployment.
      ///
      /// This grants the user access to a given deployment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse> CreateLoginTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreateLoginTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a LoginToken (LT) for a given user, project and deployment.
      ///
      /// This grants the user access to a given deployment.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenResponse> CreateLoginTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreateLoginTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateLoginToken, null, options, request);
      }
      /// <summary>
      /// Creates a PlayerIdentityToken (PIT) for a given user and project.
      ///
      /// This guarantees player identity in the context of a project.
      ///
      /// Invalid fields will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse CreatePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreatePlayerIdentityToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a PlayerIdentityToken (PIT) for a given user and project.
      ///
      /// This guarantees player identity in the context of a project.
      ///
      /// Invalid fields will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse CreatePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreatePlayerIdentityToken, null, options, request);
      }
      /// <summary>
      /// Creates a PlayerIdentityToken (PIT) for a given user and project.
      ///
      /// This guarantees player identity in the context of a project.
      ///
      /// Invalid fields will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse> CreatePlayerIdentityTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return CreatePlayerIdentityTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a PlayerIdentityToken (PIT) for a given user and project.
      ///
      /// This guarantees player identity in the context of a project.
      ///
      /// Invalid fields will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenResponse> CreatePlayerIdentityTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.CreatePlayerIdentityTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreatePlayerIdentityToken, null, options, request);
      }
      /// <summary>
      /// Decodes a PlayerIdentityToken (PIT).
      ///
      /// Tokens that cannot be verified will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse DecodePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DecodePlayerIdentityToken(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Decodes a PlayerIdentityToken (PIT).
      ///
      /// Tokens that cannot be verified will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse DecodePlayerIdentityToken(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DecodePlayerIdentityToken, null, options, request);
      }
      /// <summary>
      /// Decodes a PlayerIdentityToken (PIT).
      ///
      /// Tokens that cannot be verified will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse> DecodePlayerIdentityTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DecodePlayerIdentityTokenAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Decodes a PlayerIdentityToken (PIT).
      ///
      /// Tokens that cannot be verified will result in an `InvalidArgument` error.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenResponse> DecodePlayerIdentityTokenAsync(global::Improbable.SpatialOS.PlayerAuth.V2Alpha1.DecodePlayerIdentityTokenRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DecodePlayerIdentityToken, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override PlayerAuthServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PlayerAuthServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(PlayerAuthServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateLoginToken, serviceImpl.CreateLoginToken)
          .AddMethod(__Method_CreatePlayerIdentityToken, serviceImpl.CreatePlayerIdentityToken)
          .AddMethod(__Method_DecodePlayerIdentityToken, serviceImpl.DecodePlayerIdentityToken).Build();
    }

  }
}
#endregion
