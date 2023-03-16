using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //输入联系人的信息 显示联系人的信息
            Application.Run(new AddressForm());
            //读取时间 并 显示
            Application.Run(new TimeForm());
            //银行账户读写
            Application.Run(new AccountForm());
        }
    }
}
