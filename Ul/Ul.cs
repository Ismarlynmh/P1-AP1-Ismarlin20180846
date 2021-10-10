using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Ismarlyn_20180846.Ul
{
    class Ul
    {
        private void BuscarIDButton_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(AporteIDTextBox.Text, out int AporteID);
            var Aporte = AporteBLL.Buscar(AporteID);

            if (Aporte != null)
                this.Aportes = Aportes;
            else
            {
                this.Aportes = new Aportes();
                MessageBox.Show("No existe.", "Informacion", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            this.DataContext = this.Aportes;
        }
    }
}
