
using ormdb.Models.Database;

namespace webapi.Interface
{
    public interface IOrdenRecibo
    {
        //se define los metodos que se van a implementar en la clase OrdenRecibo

        IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisadas { get; }

        IEnumerable<OrdenReciboRevisada> ConsultaOrdenesRevisada(string ruc);

        OrdenReciboRevisada? ConsultaOrdenesRevisadaObjet(string numorden);



    }
}
