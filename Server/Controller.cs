using Common.Domain;
using Common.Domain.DTO;
using DBBroker;
using Server.SystemOperation;
using Server.SystemOperation.Licence;
using Server.SystemOperation.Mechanics;
using Server.SystemOperation.Owner;
using Server.SystemOperation.Service;
using Server.SystemOperation.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controller
    {
       // private Broker broker;

        private static Controller instance;
        public static Controller Instance
        {
            get
            {
                if (instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() {  }

        public Majstor Login(Majstor m)
        {
            SystemOperationBase so = new LoginSO(m);
            so.ExecuteTemplate();
            return ((LoginSO)so).Result;

        }

        public List<Marka> GetAllBrands()
        {
            SystemOperationBase so= new GetAllBrandsSO();
            so.ExecuteTemplate();
            return ((GetAllBrandsSO)so).Result;
        }

        internal object GetAllModels()
        {
            SystemOperationBase so= new GetAllModelsSO();
            so.ExecuteTemplate();
            return ((GetAllModelsSO)so).Result;
        }

        
        internal object GetAllVehicles()
        {
            SystemOperationBase so = new GetAllVehiclesSO();
            so.ExecuteTemplate();
            return (((GetAllVehiclesSO)so).Result);
        }
        internal object GetAllMechanics()
        {
            SystemOperationBase so = new GetAllMechanicsSO();
            so.ExecuteTemplate();
            return (((GetAllMechanicsSO)so).Result);
        }
        internal object GetAllJobs()
        {
            SystemOperationBase so = new GetAllJobsSO();
            so.ExecuteTemplate();
            return (((GetAllJobsSO)so).Result);
        }
        internal object GetAllOwners()
        {
            SystemOperationBase so = new GetAllOwnersSO();
            so.ExecuteTemplate();
            return (((GetAllOwnersSO)so).Result);
        }
        internal object GetAllServices()
        {
            SystemOperationBase so = new GetAllServicesSO();
            so.ExecuteTemplate();
            return (((GetAllServicesSO)so).Result);
        }
        
        internal object GetService(Servis? s)
        {
            SystemOperationBase so = new GetServiceSO(s);
            so.ExecuteTemplate();
            return (((GetServiceSO)so).Result);
        }
        internal object GetVehicle(Vozilo? v)
        {
            SystemOperationBase so = new GetVehicleSO(v);
            so.ExecuteTemplate();
            return (((GetVehicleSO)so).Result);
        }
        internal object SearchSevices(ServisFilter filter)
        {
            SystemOperationBase so = new SearchServiceSO(filter);
            so.ExecuteTemplate();
            return (((SearchServiceSO)so).Result);
        }

        internal object SearchVehicles(VehicleFilter? f)
        {
            SystemOperationBase so= new SearchVehicleSO(f);
            so.ExecuteTemplate();
            return (((SearchVehicleSO)so).Result);
        }
        internal void AddVehicle(Vozilo? v)
        {
            SystemOperationBaseSQL so = new AddVehicleSQLSO();
            so.IzvrsiSO(v);
            //SystemOperationBase so = new AddVehicleSO(v);
            //so.ExecuteTemplate();

        }

        internal int AddOwner(Klijent? k)
        {
            SystemOperationBaseSQL so = new AddOwnerSQLSO();
            so.IzvrsiSO(k);
            //SystemOperationBase so = new AddVehicleSO(v);
            //so.ExecuteTemplate();
            return ((AddOwnerSQLSO)so).Rezultat;
        }
        internal void AddService(Servis? s)
        {
            SystemOperationBaseSQL so = new AddServiceSQLSO();
            so.IzvrsiSO(s);
            //SystemOperationBase so = new AddServiceSO(s);
            //so.ExecuteTemplate();
        }
        internal void ChangeVehicle(Vozilo v)
        {
            SystemOperationBase so = new EditVehicleSO(v);
            so.ExecuteTemplate();
        }

        internal void DeleteVehicle(Vozilo? v)
        {
            SystemOperationBase so = new DeleteVehicle(v);
            so.ExecuteTemplate();
        }

        internal void AddLicence(MajstorLicenca? ml)
        {
            SystemOperationBaseSQL so = new AddLicenceSQLSO();
            so.IzvrsiSO(ml);
        }

        internal void EditService(Servis? s)
        {
            SystemOperationBase so = new EditServiceSO(s);
            so.ExecuteTemplate();
        }

        
    }
}
