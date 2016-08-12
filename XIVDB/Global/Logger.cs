using System;
using System.Runtime.CompilerServices;
using log4net;
using log4net.Config;
using XIVDB.Static;

namespace XIVDB.Global
{
    /// <summary>
    /// The main endpoint for logging functionality in the DatabaseLayer
    /// </summary>
    internal class Logger
    {
        #region Private Members
        private readonly string _objName;
        private readonly ILog _log;
        #endregion

        #region Properties
        #endregion

        #region Constructors

        /// <summary>
        /// Instantiates new Logger wrapper
        /// </summary>
        /// <param name="t">Type of source class</param>
        public Logger(Type t)
        {
            //Set private variables
            _objName = t.Name;
            _log = LogManager.GetLogger(_objName);
            //Initialize log4net instance
            XmlConfigurator.Configure();
        }

        /// <summary>
        /// Instantiates new Logger wrapper
        /// </summary>
        /// <param name="obj">Object of source class</param>
        public Logger(object obj)
        {
            _objName = obj.GetType().Name;
            _log = LogManager.GetLogger(_objName);
            XmlConfigurator.Configure();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Logs message in a Warning format
        /// </summary>
        /// <param name="message">Message to be logged</param>
        /// <param name="member">(Defaulted)The name of the calling method</param>
        public void Warning(string message,
            [CallerMemberName]string member = ApiConstants.EmptyString)
        {
            _log.Warn($"[{DateTime.Now}] - [{_objName} : {member}] - {message}");
        }

        public void Fatal(string message,
            [CallerMemberName] string member = ApiConstants.EmptyString)
        {
            _log.Fatal($"[{DateTime.Now}] - [{_objName} : {member}] - {message}");
        }

        public void Error(string message,
            [CallerMemberName] string member = ApiConstants.EmptyString)
        {
            _log.Error($"[{DateTime.Now}] - [{_objName} : {member}] - {message}");
        }

        public void Debug(string message,
            [CallerMemberName] string member = ApiConstants.EmptyString)
        {
            _log.Debug($"[{DateTime.Now}] - [{_objName} : {member}] - {message}");
        }

        public void Info(string message,
            [CallerMemberName] string member = ApiConstants.EmptyString)
        {
            _log.Info($"[{DateTime.Now}] - [{_objName} : {member}] - {message}");
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
