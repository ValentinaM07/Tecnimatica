namespace Api_Tecnimatica.DAO
{
    public class Login
    {
        public string email { get; set; }
        public string contrasena { get; set; }
        public Login(string email, string contrasena)
        {
            this.email = email;
            this.contrasena = contrasena;
        }
        public Login()
        {
            
        }
    }
}
