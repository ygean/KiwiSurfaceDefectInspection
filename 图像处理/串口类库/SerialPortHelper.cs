using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图像处理.串口类库
{
    public class SerialPortHelper
    {
        public static void GetSerialPort()
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            //mycomm.ReadTimeout = 32;
           
        }
        
    }
}
