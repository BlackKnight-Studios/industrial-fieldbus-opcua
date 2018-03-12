using System;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace OmegaGaze.Fieldbus
{
    public class SiemensS7PlcDriver
    {
        public string IpAddress { get; }
        public int Rack { get; }
        public int Slot { get; }
        public bool Connected { get; private set; }

        public SiemensS7PlcDriver(string ip, int rack = 0, int slot = 1)
        {
            IpAddress = ip;
            Rack = rack;
            Slot = slot;
        }

        public async Task<bool> OpenAsync()
        {
            await Task.Delay(30);
            Connected = true;
            return true;
        }

        public byte[] ReadDbBytes(int dbNumber, int startByte, int length)
        {
            var buffer = new byte[length];
            // Synthetic test pattern for virtual commissioning verification
            for (int i = 0; i < length; i++) buffer[i] = (byte)((dbNumber + i) % 255);
            return buffer;
        }
    }
}
