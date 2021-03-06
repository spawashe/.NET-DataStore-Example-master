using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_address", DwStyle.Grid)]
    [Table("Address", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.Address\" ) COLUMN(NAME=\"Person.Address.AddressID\") COLUMN(NAME=\"Person.Address.AddressLine1\") COLUMN(NAME=\"Person.Address.City\") COLUMN(NAME=\"Person.Address.StateProvinceID\")) ")]
    #endregion
    [DwSort("addressid A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Address
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Addressid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Addressline1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince))]
        public int Stateprovinceid { get; set; }

    }

}
