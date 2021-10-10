using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AP1_Ismarlyn_20180846.Ul
{
    class nuevo
    {
        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            AporteIDTextBox.Text = string.Empty;
            fechaTextBox.SelectedDate = DateTime.Now;
            personaTextBox.Text = string.Empty;
            conceptoTextBox.Text = string.Empty;
            montoTextBox.Text = string.Empty;
        }
    }
}
