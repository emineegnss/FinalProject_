using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Public olduğu için pascal case yazılır ama private olsaydı camelcase yazılırdı
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Listelendi";
    }
}
