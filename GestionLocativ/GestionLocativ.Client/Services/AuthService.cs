namespace GestionLocativ.Client.Services
{
    public class AuthService
    {
        public bool IsAuthenticated { get; private set; }

        public event Action? AuthenticationStateChanged;

        public void Login(string user, string password)
        {
            // In a real app, validate credentials here
            IsAuthenticated = true;
            AuthenticationStateChanged?.Invoke();
        }

        public void Register(string user, string password)
        {
            // Registration logic would go here
            IsAuthenticated = true;
            AuthenticationStateChanged?.Invoke();
        }

        public void ResetPassword(string email)
        {
            // Send reset email in a real app
        }

        public void Logout()
        {
            IsAuthenticated = false;
            AuthenticationStateChanged?.Invoke();
        }
    }
}
