using System.Security.Principal;
using Common.Domain;
namespace DataBaseBroker
{
    public interface IGenerickiRepo
    {
        int Sacuvaj(IEntity objekat);
        //int Izmeni(IEntity objekat);
        //int Izbrisi(IEntity objekat);
        //IEntity VratiJedan(IEntity objekat);
        //List<IEntity> VratiSve(IEntity objekat);
        //List<IEntity> Pretraga(IEntity objekat, string kriterijum);
        //List<IEntity> PretragaTekst(IEntity objekat, string kriterijum);
        //List<IEntity> VratiSveZaNekog(IEntity objekat);
        void OtvoriKonekciju();
        void ZatvoriKonekciju();
        void ZapocniTransakciju();
        void Commit();
        void RollBack();
    }
}
