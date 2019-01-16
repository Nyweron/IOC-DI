namespace ConsoleApp1
{
    public class With_IoC_DI
    {
        public class IISAppPoolWatcherIoC_DI
        {
            INotificationAction action = null;

            public IISAppPoolWatcherIoC_DI(INotificationAction concreteImplementation)
            {
                this.action = concreteImplementation;
            }

            public void Notify(string message)
            {
                action.ActOnNotification(message);
            }
        }
    }
}
