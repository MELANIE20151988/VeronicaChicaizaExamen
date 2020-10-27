namespace VeronicaChicaizaExamen
{
    public class Login
    {
        public string Username { get; set; }
        public string Pass { get; set; }
        public Login() { }
        public Login(string Username, string Pass)
        {
            this.Username = Username;
            this.Pass = Pass;
        }
        public bool Informacion()
        {
            if (this.Username.Equals("estudiante2020") && this.Pass.Equals("uisrael2020"))
                return true;

            else
                return false;

        }



    }



}
