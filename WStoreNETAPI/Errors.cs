using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace WStoreNETAPI
{
    class Errors
    {
        public static string noInfo = "{\"status\":\"101\"";
        public static string invalidHS = "SSL handshake failed";
        public static void InvalidKey()
        {
            MessageBox.Show("Невалиден API KEY", "W-STORE | API");
        }
        public static void KeyNotSET()
        {
            MessageBox.Show("Моля, задайте вашият API KEY", "W-STORE | API");
        }
        public static void NoOrders()
        {
            MessageBox.Show("Няма намерени резултати или информация", "W-STORE | API");
        }
        public static void InvalidHandshake()
        {
            MessageBox.Show("В момента има проблем със сайта", "W-STONE | API");
        }
    }
}
