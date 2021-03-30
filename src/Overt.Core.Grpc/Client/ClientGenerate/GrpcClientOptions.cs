﻿using Grpc.Core;
using Grpc.Core.Interceptors;
using Overt.Core.Grpc.Intercept;
using System.Collections.Generic;

namespace Overt.Core.Grpc
{
    /// <summary>
    /// 全局客户端配置模型
    /// </summary>
    public class GrpcClientOptions
    {
        /// <summary>
        /// tracer拦截器
        /// </summary>
        public IClientTracer Tracer { get; set; }

        /// <summary>
        /// Gets a list of <see cref="Interceptor"/> instances used to configure a gRPC client pipeline.
        /// </summary>
        public List<Interceptor> Interceptors { get; } = new List<Interceptor>();

        ///// <summary>
        ///// 服务名称
        ///// </summary>
        //internal string ServiceName { get; set; }

        ///// <summary>
        ///// 最大重试次数
        ///// </summary>
        //internal int MaxRetry { get; set; }

        ///// <summary>
        ///// 获取Invoker
        ///// </summary>
        //internal Func<List<ServerCallInvoker>, ServerCallInvoker> GetInvoker { get; set; }
    }

    /// <summary>
    /// 单服务客户端配置
    /// </summary>
    public class GrpcClientOptions<T> where T : ClientBase
    {
        /// <summary>
        /// Json文件
        /// defaultValue: dllconfigs/clientsettings.json 
        /// </summary>
        public string ConfigPath { get; set; }
    }
}
