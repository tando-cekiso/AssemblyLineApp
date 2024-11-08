using AssemblyLineApp.Services;

namespace AssemblyLineApp.Data
{
    public class DeviceService : IDeviceService
    {
        private readonly List<Devices> _devices = new();
        public void AddDevice(Devices device)
        {
            device.DeviceId = _devices.Any() ? _devices.Max(d => d.DeviceId) + 1 : 1;
            _devices.Add(device);
        }

        public IEnumerable<Devices> GetDevices() => _devices;
       

        public void RemoveDevice(int deviceId) => _devices.RemoveAll(d => d.DeviceId == deviceId);


       

        public void UpdateDevice(Devices device)
        {
            var existingDevice = _devices.FirstOrDefault(d => d.DeviceId == device.DeviceId);
            if (existingDevice != null)
            {
                existingDevice.Name = device.Name;
                
            }
        }


        //private void SampleDevices()
        //{
        //    _devices.Add(new Devices
        //    {
        //        DeviceId = 1,
        //        Name = "Iventory Scanner",
        //        DeviceType = DeviceType.QualityAssuranceScanner
        //    });

        //    _devices.Add(new Devices
        //    {
        //        DeviceId = 2,
        //        Name = "Tag Writer",
        //        DeviceType = DeviceType.LaserCutter
        //    });
        //}
    }
}
