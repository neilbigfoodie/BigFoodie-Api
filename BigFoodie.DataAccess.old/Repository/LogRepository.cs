using System;
using BigFoodie.DataAccess.Repository.Base;

namespace BigFoodie.DataAccess.Repository
{

    public enum LogLevel
    {
        info,
        Warning,
        Error
    }

    public interface ILogRepository : IDisposable
    {
        void Log(LogLevel level, string message);
    }

    public class LogRepository : ILogRepository
    {
        protected bool _disposed = false;
        private IEfRepository _efRepository;

        public LogRepository(IEfRepository efRepository)
        {
            _efRepository = efRepository;
        }

        public void Log(LogLevel level, string message)
        {
           // var log = new ErrorLog {CreatedDateTime = DateTime.Now, Type = level.ToString(), Message = message};
           // _efRepository.Add(log);
        }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    
                }
                _disposed = true;
            }
        }

        #endregion

    }
}
