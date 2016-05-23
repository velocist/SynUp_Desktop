using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynUp_Desktop.utilities
{
    public static class Literal
    {
        public static readonly string WARNING_ICON = "\\views\\images\\warning.png";
        public static readonly string ERROR_ICON = "\\views\\images\\error.png";
        public static readonly string INFORMATION_ICON = "\\views\\images\\information.png";
        public static readonly string ERROR_VALIDATION_EMPLOYEE = "The NIF and/or the e-mail can't be empty.";
        public static readonly string INFO_NIF_EMPLOYEE =   "Numero Identificación Fiscal. It can't be empty and must be valid. " +
                                                            "To change the NIF contact with the database administrator.";
    }
}
