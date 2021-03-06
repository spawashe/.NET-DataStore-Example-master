using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_catesel", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Catesel
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Productcategoryid", "Name", typeof(D_Dddw_Category))]
        public decimal? Id { get; set; }

    }

}
