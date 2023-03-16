using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Account
    {
        private int id;
        private double money;

        public Account() {
            id = (new System.Random()).Next(100000, 499999);
            money = 100.0;
        }

        public int Id { get { return id; } }
        public double Money { get { return money; } }

        /// <summary>
        /// 创建账户提示信息
        /// </summary>
        /// <returns></returns>
        public String GetIdInfo()
        {
            return String.Format("创建账户成功!\n账户卡号为{0}\n余额为{1}", Id, Money);
        }
        /// <summary>
        /// 存储提示信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public String StoreMoney(double num)
        {
            money += num;
            return String.Format("操作成功!\n存款{0}元\n", num);
        }
        /// <summary>
        /// 取款提示信息
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public String GetMoney(double num)
        {
            if(money < num)
            {
                return String.Format("当前取款金额超过了余额\n当前余额为{0}\n", Money);
            }
            money -= num;
            return String.Format("取款成功!\n取款{0}元\n", num);
        }
        /// <summary>
        /// 获得当前余额
        /// </summary>
        /// <returns></returns>
        public String GetFormatMoney()
        {
            return String.Format("储蓄卡账户:\n{0}\n当前余额为:{1}", id, Money);
        }
    }
}
