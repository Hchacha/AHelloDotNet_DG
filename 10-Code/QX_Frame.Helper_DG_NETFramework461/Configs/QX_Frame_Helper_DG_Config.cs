/**
 * author:qixiao
 * create:2017-5-15 17:24:34
 * desc:Helper_DG configuration
 * */
namespace QX_Frame.Helper_DG.Configs
{
    public class QX_Frame_Helper_DG_Config
    {
        #region database

        /// <summary>
        /// qx_frame default connection string
        /// </summary>
        public static string ConnectionString_DB_QX_Frame_Default { get; set; } = default(string);

        #endregion

        #region log

        public static string Log_Location_General { get; set; } = @"Log_QX_Frame/Log_QX_Frame_General/";
        public static string Log_Location_Error { get; set; } = @"Log_QX_Frame/Log_QX_Frame_Error/";
        public static string Log_Location_Use { get; set; } = @"Log_QX_Frame/Log_QX_Frame_Use/";

        #endregion

        #region cache

        public static bool Cache_IsCache { get; set; } = false;
        public static int Cache_CacheExpirationTime_Minutes { get; set; } = 10;

        #endregion
    }
}
