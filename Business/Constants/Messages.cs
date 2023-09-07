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
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde başka bir ürün vardır";
        public static string CategoryLimitExceded = "Kategori Limiti aşıldı ve ürün eklenemiyor";
    }
}
