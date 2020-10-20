using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;


namespace ProjetoIntegrador2014.Formularios
{
    public class Tools
    {
        public Tools()
        {
 
        }

        public bool ChecaCampoNullo(Control ctlNome)
        {
            foreach (Control ctl in ctlNome.Controls)
            {
                if (ctl is RadTextBox || ctl is RadMaskedEditBox || ctl is RadDropDownList || ctl is RichTextBox || ctl is RadMultiColumnComboBox)
                {
                    if (ctl.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void LimpaCampos(Control ctlNome)
        {
            foreach (Control ctl in ctlNome.Controls)
            {
                if (ctl is RadTextBox || ctl is RadMaskedEditBox || ctl is RadDropDownList || ctl is RichTextBox || ctl is RadMultiColumnComboBox)
                {
                    ctl.Text = "";
                }
            }
        }
    }
}
