using Chapter_14._11_Access_Control.SecureDocumentProxy;

namespace Chapter_14._11_Access_Control.Auth_System
{
    class AuthenticatedViewer
    {
        public void Run()
        {
            AuthService auth = new AuthService();
            IDocument doc = new AuthenticatedDocumentProxy(auth);
            doc.View(); // Access depends on role returned by AuthService
        }
    }
}
