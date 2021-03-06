// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: session/service.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace NeoFS.API.Session {
  public static partial class Session
  {
    static readonly string __ServiceName = "session.Session";

    static readonly grpc::Marshaller<global::NeoFS.API.Session.CreateRequest> __Marshaller_session_CreateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Session.CreateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::NeoFS.API.Session.CreateResponse> __Marshaller_session_CreateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::NeoFS.API.Session.CreateResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::NeoFS.API.Session.CreateRequest, global::NeoFS.API.Session.CreateResponse> __Method_Create = new grpc::Method<global::NeoFS.API.Session.CreateRequest, global::NeoFS.API.Session.CreateResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Create",
        __Marshaller_session_CreateRequest,
        __Marshaller_session_CreateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::NeoFS.API.Session.ServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Session</summary>
    public partial class SessionClient : grpc::ClientBase<SessionClient>
    {
      /// <summary>Creates a new client for Session</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SessionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Session that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SessionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SessionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SessionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Create is a method that used to open a trusted session to manipulate
      /// an object. In order to put or delete object client have to obtain session
      /// token with trusted node. Trusted node will modify client's object
      /// (add missing headers, checksums, homomorphic hash) and sign id with
      /// session key. Session is established during 4-step handshake in one gRPC stream
      ///
      /// - First client stream message SHOULD BE type of `CreateRequest_Init`.
      /// - First server stream message SHOULD BE type of `CreateResponse_Unsigned`.
      /// - Second client stream message SHOULD BE type of `CreateRequest_Signed`.
      /// - Second server stream message SHOULD BE type of `CreateResponse_Result`.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::NeoFS.API.Session.CreateRequest, global::NeoFS.API.Session.CreateResponse> Create(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Create(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Create is a method that used to open a trusted session to manipulate
      /// an object. In order to put or delete object client have to obtain session
      /// token with trusted node. Trusted node will modify client's object
      /// (add missing headers, checksums, homomorphic hash) and sign id with
      /// session key. Session is established during 4-step handshake in one gRPC stream
      ///
      /// - First client stream message SHOULD BE type of `CreateRequest_Init`.
      /// - First server stream message SHOULD BE type of `CreateResponse_Unsigned`.
      /// - Second client stream message SHOULD BE type of `CreateRequest_Signed`.
      /// - Second server stream message SHOULD BE type of `CreateResponse_Result`.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::NeoFS.API.Session.CreateRequest, global::NeoFS.API.Session.CreateResponse> Create(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Create, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SessionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SessionClient(configuration);
      }
    }

  }
}
#endregion
