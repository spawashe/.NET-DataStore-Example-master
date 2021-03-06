using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_address_free", DwStyle.Default)]
    [Table("Address", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Person.Address.addressid, " 
                  + "Person.Address.addressline1, "
                  + "Person.Address.addressline2, "
                  + "Person.Address.city, "
                  + "Person.Address.stateprovinceid, "
                  + "Person.Address.postalcode, "
                  + "Person.Address.modifieddate "
                  + "FROM Person.Address "
                  + "WHERE Person.Address.addressid = :al_addressid")]
    #endregion
    [DwParameter("al_addressid", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Address_Free
    {
        [Identity]
        [Key]
        [DefaultValue("0")]
        public int Addressid { get; set; }

        public string Addressline1 { get; set; }

        public string Addressline2 { get; set; }

        public string City { get; set; }

        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince))]
        public int? Stateprovinceid { get; set; }

        public string Postalcode { get; set; }

        [DefaultValue("2019/01/01")]
        public DateTime? Modifieddate { get; set; }

    }

}
