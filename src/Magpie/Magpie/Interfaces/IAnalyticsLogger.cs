﻿namespace Magpie.Interfaces
{
    public interface IAnalyticsLogger
    {
        void LogDownloadNow();
        void LogSkipThisVersion();
        void LogRemindMeLater();
        void LogContinueWithInstallation();
        void LogOldVersion(string oldVersion);
        void LogNewVersion(string s);
        void LogAppTitle(string mySuperAwesomeApp);
        void LogUpdateCancelled();
    }
}