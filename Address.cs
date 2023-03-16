using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Address
    {
        private string name;
        private string phone;
        private string email;
        public Address(string name, string phone, string email) {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public string Name { get { return name; } }
        public string Phone { get { if (phone == null || phone == "") return "未输入";  return phone; } set { phone = value; } }
        public string Email { get { if (email == null || email == "") return "未输入"; return email; } set { email = value; } }

        /// <summary>
        /// 获得当前对象存储的信息的格式化输出字符串
        /// </summary>
        /// <returns></returns>
        public string GetMessage()
        {
            return string.Format("姓名:{0}\n电话:{1}\nEmail:{2}", Name, Phone, Email);
        }

    }
}
