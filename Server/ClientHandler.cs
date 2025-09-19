using Common.Communication;
using Common.Domain;
using Common.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        private JsonNetworkSerializer serializer;
        private Socket socket;
        private readonly Server server;

        public ClientHandler(Socket socket, Server server)
        {
            this.socket = socket;
            this.server = server;
            serializer = new JsonNetworkSerializer(socket);
        }
        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = serializer.Receive<Request>();
                    Response r = ProcessRequest(req);
                    serializer.Send(r);
                }
            }
            catch (SocketException)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta");
            }
            catch (IOException)
            {
                Debug.WriteLine("Komunikacija sa klijentom je prekinuta");
            }
            finally
            {
                if (socket.Connected)
                {
                    socket.Close();
                }
                server.RemoveClient(this);
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response r = new Response();
            Vozilo v;
            Servis s;
            Klijent k;
            try
            {
                switch (req.Operation)
                {
                    //case Operation.CreateKlijent:
                    //    Controller.Instance.AddPerson(serializer.ReadType<Klijent>(req.Argument));
                    //    break;
                    case Operation.Login:
                        r.Result = Controller.Instance.Login(serializer.ReadType<Majstor>(req.Argument));
                        break;

                    case Operation.GetAllBrands:
                        r.Result = Controller.Instance.GetAllBrands();
                        break;
                    case Operation.GetAllModels:
                        r.Result = Controller.Instance.GetAllModels();
                        break;
                    case Operation.GetAllVehicles:
                        r.Result = Controller.Instance.GetAllVehicles();
                        break;
                    case Operation.GetAllMechanics:
                        r.Result = Controller.Instance.GetAllMechanics();
                        break;
                    case Operation.GetAllJobs:
                        r.Result = Controller.Instance.GetAllJobs();
                        break;
                    case Operation.GetAllOwners:
                        r.Result = Controller.Instance.GetAllOwners();
                        break;
                    case Operation.GetAllServices:
                        r.Result = Controller.Instance.GetAllServices();
                        break;
                    case Operation.GetService:
                        s = JsonSerializer.Deserialize<Servis>((JsonElement)req.Argument);
                        r.Result = Controller.Instance.GetService(s);
                        break;
                    case Operation.GetVehicle:
                        v = JsonSerializer.Deserialize<Vozilo>((JsonElement)req.Argument);
                        r.Result = Controller.Instance.GetVehicle(v);
                        break;
                    case Operation.SearchServices:
                        ServisFilter filter = JsonSerializer.Deserialize<ServisFilter>((JsonElement)req.Argument);
                        r.Result = Controller.Instance.SearchSevices(filter);
                        break;
                    case Operation.SearchVehicles:
                        
                        var f = JsonSerializer.Deserialize<VehicleFilter>((JsonElement)req.Argument);
                        r.Result = Controller.Instance.SearchVehicles(f);
                            
                        break;
                        
                    case Operation.AddVehicle:
                        v = JsonSerializer.Deserialize<Vozilo>((JsonElement)req.Argument);
                        Controller.Instance.AddVehicle(v);
                        break;
                    case Operation.AddOwner:
                        
                        k = JsonSerializer.Deserialize<Klijent>((JsonElement)req.Argument);
                        Controller.Instance.AddOwner(k);
                        break;
                    case Operation.AddService:
                        s = JsonSerializer.Deserialize<Servis>((JsonElement)req.Argument);
                        Controller.Instance.AddService(s);
                        break;
                    case Operation.SaveServiceChanges:
                        s = JsonSerializer.Deserialize<Servis>((JsonElement)req.Argument);
                        Controller.Instance.EditService(s);
                        break;
                    case Operation.AddLicence:
                        MajstorLicenca ml = JsonSerializer.Deserialize<MajstorLicenca>((JsonElement)req.Argument);
                        Controller.Instance.AddLicence(ml);
                        break;
                    case Operation.ChangeVehicle:
                        v = JsonSerializer.Deserialize<Vozilo>((JsonElement)req.Argument);
                        Controller.Instance.ChangeVehicle(v);
                        break;
                    case Operation.DeleteVehicle:
                        v = JsonSerializer.Deserialize<Vozilo>((JsonElement)req.Argument);
                        Controller.Instance.DeleteVehicle(v);
                        break;

                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(r.ExceptionMessage);
                r.ExceptionMessage = ex.Message;
            }
            return r;
        }

        internal void CloseSocket()
        {
            socket.Close();
           
        }
    }
}
