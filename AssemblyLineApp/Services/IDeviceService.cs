using AssemblyLineApp.Data;

namespace AssemblyLineApp.Services
{
    public interface IDeviceService
    {
        void AddDevice(Devices device);
        IEnumerable<Devices> GetDevices();

        void RemoveDevice(int deviceId);


        void UpdateDevice(Devices device);
    }
}
