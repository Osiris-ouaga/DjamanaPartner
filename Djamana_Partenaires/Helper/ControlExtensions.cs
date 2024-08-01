using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djamana.Partenaires.UI.Helper
{
    public static class ControlExtensions
    {
        public static void SetEnabled(this Control control, bool enabled)
        {
            foreach (Control c in control.Controls)
            {
                c.Enabled = enabled;
                if (c.Controls.Count > 0)
                {
                    SetEnabled(c, enabled);
                }
            }
        }
    }

}
