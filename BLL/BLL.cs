using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Ismarlyn_20180846.BLL
{
    class BLL
    {
        public static bool Eliminar(int AporteID)
        {
            bool Esta = false;
            Contexto contexto = new Contexto();
            try
            {
                Aportes Aporte = contexto.Aporte.Find(AporteID);

                if (Existe(AporteID))
                {
                    contexto.Aporte.Remove(Aporte);
                    Esta = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            { throw; }
            finally
            {
                contexto.Dispose();
            }
            return Esta;
        }
        public static Aporte BuscarAporte(int AporteID)
        {
            Contexto contexto = new Contexto();
            Aportes Aporte = new Aporte();
            try
            {
                Aporte = contexto.Aporte.Find(AporteID);

            }
            catch (Exception)
            { throw; }
            finally
            {
                contexto.Dispose();
            }
            return Aporte;
        }
    }
}
