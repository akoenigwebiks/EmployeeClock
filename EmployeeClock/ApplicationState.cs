using System;

namespace EmployeeClock
{
    public class ApplicationState
    {
        private static readonly Lazy<ApplicationState> instance = new Lazy<ApplicationState>(() => new ApplicationState());

        // Example property
        public string username { get; set; } = string.Empty;
        public string userId { get; set; }

        // Private constructor ensures only this class can instantiate itself
        private ApplicationState() { }

        // Public property to access the instance
        public static ApplicationState Instance
        {
            get { return instance.Value; }
        }
    }
}