
using ormdb.Models.Database;


namespace webapi.DA
{
    public class DataRepositoryOrdenRecibo
    {
        public List<OrdenReciboRevisada> ConsultaOrdenesRevisada()
        {
            using(var ctx = new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.ToList();
            }

        }
        public List<OrdenReciboRevisada> ConsultaOrdenesRevisada(string ruc)
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.Where(a => a.RucProveedor == ruc).ToList();
            }
        }
        public OrdenReciboRevisada? ConsultaOrdenesRevisadaObjet(string numorden)
        {
            using (var ctx = new OrdenreciboContext())
            {
                return ctx.OrdenReciboRevisadas.Where(a=>a.NumOrdenRecibo == numorden).FirstOrDefault();

            }
        }
    }
}
