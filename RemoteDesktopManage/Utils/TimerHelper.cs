using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RdpManage.Utils
{
    public static class TimerHelper
    {
        /// <summary>
        /// 在指定时间过后执行指定的表达式
        /// </summary>
        /// <param name="interval">时间（以毫秒为单位）</param>
        /// <param name="action">要执行的表达式</param>
        /// <return>返回timer对象</return>
        public static Timer SetTimeout(Action action, double interval)
        {
            var timer = new Timer(interval);
            timer.Elapsed += (sender, e) =>
            {
                timer.Enabled = false;
                action();
            };
            timer.Enabled = true;
            return timer;
        }
    }
}
