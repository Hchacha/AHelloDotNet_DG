using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

/**
 * author:qixiao
 * create:2017-6-5 10:47:01
 * */
namespace QX_Frame.Helper_DG
{
    public class Redis_Helper_DG
    {
        /// <summary>
        /// Host
        /// </summary>
        public static string Host { get; set; } = "127.0.0.1";
        /// <summary>
        /// Port
        /// </summary>
        public static int Port { get; set; } = 6379;
        /// <summary>
        /// client
        /// </summary>
        private static IRedisClient client;

        /// <summary>
        /// singleton object
        /// </summary>
        private static readonly object lockHelper = new object();
        static Redis_Helper_DG()
        {
            if (client == null)
            {
                lock (lockHelper)
                {
                    if (client == null)
                        client = new RedisClient(Host, Port);
                }
            }
        }
        /// <summary>
        /// Get RedisClient
        /// </summary>
        public static IRedisClient Client
        {
            get => client;
        }
    }
}
