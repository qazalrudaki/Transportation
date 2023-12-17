using System;

namespace Transportation.Persistant.Models
{
    public class DriverModel
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string DriverFamily { get; set; }
        public string CarTag { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public string NationalCode { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDateTime { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDateTime { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class CreateDriverModel
    {
        public string DriverName { get; set; }
        public string DriverFamily { get; set; }
        public string CarTag { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public string NationalCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class UpdateDriverModel
    {
        public int Id { get; set; }
        public string DriverName { get; set; }
        public string DriverFamily { get; set; }
        public string CarTag { get; set; }
        public string CarName { get; set; }
        public string CarColor { get; set; }
        public string NationalCode { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }
}
