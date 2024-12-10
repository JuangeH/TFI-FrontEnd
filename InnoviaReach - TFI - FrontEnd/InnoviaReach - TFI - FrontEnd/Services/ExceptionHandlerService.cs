namespace InnoviaReach___TFI___FrontEnd.Services
{
    public class ExceptionHandlerService
    {
        public bool HasError { get; private set; }
        public string? ErrorMessage { get; private set; }

        public void HandleException(Exception exception)
        {
            HasError = true;
            ErrorMessage = exception.Message;
        }

        public void ClearError()
        {
            HasError = false;
            ErrorMessage = null;
        }
    }
}
