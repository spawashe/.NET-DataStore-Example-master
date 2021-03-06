using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_addresstype", DwStyle.Grid)]
    [Table("AddressType", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.AddressType\" ) COLUMN(NAME=\"Person.AddressType.AddressTypeID\") COLUMN(NAME=\"Person.AddressType.Name\")) ")]
    #endregion
    [DwSort("addresstypeid A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Dddw_Addresstype
    {
        [Identity]
        [Key]
        public int Addresstypeid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

    }

}
