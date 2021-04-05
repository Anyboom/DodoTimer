using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DodoTimer.Services
{
    class LogService
    {
        private enum Levels
        {
            WARN,
            ERROR,
            DEBUG,
            INFO
        }

        public static void Error(string message) => Log(Levels.ERROR, message);
        public static void Debug(string message) => Log(Levels.DEBUG, message);
        public static void Info(string message) => Log(Levels.INFO, message);
        public static void Warn(string message) => Log(Levels.WARN, message);

        private static void Log(Levels level, string message)
        {
            Directory.CreateDirectory("Logs");
            File.AppendAllText($"Logs/{DateTime.Now:d}.txt", $"[{DateTime.Now:T}][{level}]: {message} {Environment.NewLine}");
        }
    }
}
