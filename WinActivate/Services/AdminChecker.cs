using System.Security.Principal;

namespace WinActivate.Services
{
    public class AdminChecker
    {
        public bool CheckAdminAccess()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
