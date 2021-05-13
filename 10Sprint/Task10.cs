public class DbLogger : ILogger
    {
        public void LogMessage(string mMessage)
        {
            //Code to write message in database.  
        }
    }

    public class FileLogger : ILogger
    {
        public void LogMessage(string mStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }

    public class ExceptionLogger
    {
        ILogger _logger;
        public ExceptionLogger(ILogger iLogger)
        {
            _logger = iLogger;
        }
        public ExceptionLogger() { }
        public void LogIntoFile(Exception mException)
        {
            FileLogger objFileLogger = new FileLogger();
            objFileLogger.LogMessage(GetUserReadableMessage(mException));
        }
        public void LogIntoDataBase(Exception mException)
        {
            DbLogger objDbLogger = new DbLogger();
            objDbLogger.LogMessage(GetUserReadableMessage(mException));
        }
        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user   
            // readable format.  
            return strMessage;
        }
        public void LogException(Exception ex)
        {

        }
    }

    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            catch (IOException ex)
            {
                new ExceptionLogger().LogIntoDataBase(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }
    public interface ILogger
    {
        void LogMessage(string mes);
    }
