using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_category", DwStyle.Grid)]
    [Table("ProductCategory", Schema = "Production")]
    [DwSort("Productcategoryid")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"production.productcategory\" ) COLUMN(NAME=\"production.productcategory.productcategoryid\") COLUMN(NAME=\"production.productcategory.name\")) ")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Dddw_Category
    {
        [Identity]
        [Key]
        public int Productcategoryid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

    }

}
