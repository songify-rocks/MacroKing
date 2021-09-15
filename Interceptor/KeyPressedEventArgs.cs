using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interceptor
{
    public class KeyPressedEventArgs : EventArgs
    {
        public Keys Key { get; set; }
        public KeyState State { get; set; }
        public bool Handled { get; set; }

        public string GetHardwareId(int device, IntPtr context, int inputLength = 500)
        {
            byte[] bytes = new byte[inputLength];

            int length = InterceptionDriver.GetHardwareId(context, device, bytes, (uint)inputLength);
            if (length > inputLength)
                return null;

            int al = length / 2;
            return Encoding.Unicode.GetString(bytes).Substring(0, al);
        }
    }
}
