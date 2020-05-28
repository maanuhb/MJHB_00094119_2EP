namespace Hugo_APP_Parcial_02_POO.Modelo
{
    public class Usuario
    {
           public string fullname { get; set; }
                public string username { get; set; }
                public string  password { get; set; }
                public bool usertype { get; set; }
        
                public Usuario()
                {
                    fullname = "";
                    username = "";
                    password = "";
                    usertype = false;
                }
    }
}