using ormdb.Models.Database;
using webapi.Interface;
using webapi.DA;

//using webapi.DA;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace webapi.service

{
    public class ServicesOdenRecibo : IOrdenRecibo
    {
        public DataRepositoryOrdenRecibo data = new DataRepositoryOrdenRecibo();
        public IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisadas
        {
            get { return data.ConsultaOrdenesRevisada(); }
        }

        public IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisada(string ruc)
        {
            return data.ConsultaOrdenesRevisada(ruc);
        }

        public  OrdenReciboRevisada? ConsultaOrdenesRevisadaObjet(string numorden)
        {
            return data.ConsultaOrdenesRevisadaObjet(numorden);
        }
    }
}

