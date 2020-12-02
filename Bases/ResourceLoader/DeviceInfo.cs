namespace DevExpress.Blazor.Internal {
    public class DeviceInfo {
        public bool InLoading { get; }
        public bool IsMobileDevice { get; set; }
        public bool IsTablet { get; set; }

        public DeviceInfo() { }
        public DeviceInfo(bool isInLoading) {
            InLoading = isInLoading;
        }
        public bool HasAccurateInput => !IsTablet && !IsMobileDevice;
    }
}
