// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gateway/gateway.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Improbable.OnlineServices.Proto.Gateway {
  public static partial class GatewayService
  {
    static readonly string __ServiceName = "gateway.GatewayService";

    static readonly grpc::Marshaller<global::Improbable.OnlineServices.Proto.Gateway.JoinRequest> __Marshaller_gateway_JoinRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Improbable.OnlineServices.Proto.Gateway.JoinRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);

    static readonly grpc::Method<global::Improbable.OnlineServices.Proto.Gateway.JoinRequest, global::Google.LongRunning.Operation> __Method_Join = new grpc::Method<global::Improbable.OnlineServices.Proto.Gateway.JoinRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Join",
        __Marshaller_gateway_JoinRequest,
        __Marshaller_google_longrunning_Operation);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Improbable.OnlineServices.Proto.Gateway.GatewayReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GatewayService</summary>
    public abstract partial class GatewayServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> Join(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GatewayService</summary>
    public partial class GatewayServiceClient : grpc::ClientBase<GatewayServiceClient>
    {
      /// <summary>Creates a new client for GatewayService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GatewayServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GatewayService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GatewayServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GatewayServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GatewayServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Google.LongRunning.Operation Join(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Join(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Google.LongRunning.Operation Join(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Join, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> JoinAsync(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return JoinAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> JoinAsync(global::Improbable.OnlineServices.Proto.Gateway.JoinRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Join, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GatewayServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GatewayServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GatewayServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Join, serviceImpl.Join).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GatewayServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Join, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Improbable.OnlineServices.Proto.Gateway.JoinRequest, global::Google.LongRunning.Operation>(serviceImpl.Join));
    }

  }
}
#endregion