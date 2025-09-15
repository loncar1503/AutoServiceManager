using Common.Communication;
using Common.Domain;
using ComponentFactory.Krypton.Toolkit;
using Client.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Client
{
    internal class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }
        private Communication()
        {

        }

        private Socket socket;
        private JsonNetworkSerializer serializer;

        public void Connect()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect("127.0.0.1", 9999);
            serializer = new JsonNetworkSerializer(socket);

        }

        internal Response Login(Majstor majstor)
        {
            Request req = new Request
            {
                Argument = majstor,
                Operation = Common.Communication.Operation.Login
            };
            serializer.Send(req);
            Response response = serializer.Receive<Response>();

            //if (response.ExceptionMessage != null)
            //{
            //    throw new Exception(response.ExceptionMessage);
            //}

            response.Result = serializer.ReadType<Majstor>(response.Result); // deserijalizujemo result u user-a
            return response;
        }

        public void PosaljiZahtevBezRezultata(Common.Communication.Operation operacija, object zahtevObjekat = null)
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            VratiRezultat();
        }

        public Rezultat PosaljiZahtevVratiRezultat<Rezultat>(Common.Communication.Operation operacija, object zahtevObjekat = null) where Rezultat : class
        {
            PosaljiZahtev(operacija, zahtevObjekat);
            return VratiRezultat<Rezultat>();
        }

        private void VratiRezultat()
        {
            Response odgovor = serializer.Receive<Response>();
            if (odgovor.ExceptionMessage!=null)
            {
                throw new SystemOperationException(odgovor.ExceptionMessage);
            }
        }

        private Rezultat VratiRezultat<Rezultat>() where Rezultat : class
        {
            Response odgovor = serializer.Receive<Response>();

            if (odgovor.Signal)
            {
                return JsonSerializer.Deserialize<Rezultat>((JsonElement)odgovor.Result);
            }
            else
            {
                throw new SystemOperationException(odgovor.Result);
            }
        }

        private void PosaljiZahtev(Common.Communication.Operation operacija, object objekat = null)
        {
            try
            {
                Request z = new Request
                {
                    Operation = operacija,
                    Argument = objekat
                };
                serializer.Send(z);
            }
            catch (IOException ex)
            {
                //MessageBox.Show("PREKINUTA KOMUNIKACIJA!");
                throw new ServerCommunicationException(ex.Message);
            }
        }
    }
}
