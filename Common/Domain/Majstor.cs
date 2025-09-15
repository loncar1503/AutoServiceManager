namespace Common.Domain
{
    public class Majstor
    {
        public int Id { get; set; }  
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Specijalizacija { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public List<MajstorLicenca> MajstorLicenca { get; set; }
        public List<Servis> Servisi { get; set; }

        public override string ToString()
        {
            return Ime + " "+Prezime;
        }
    }
}
