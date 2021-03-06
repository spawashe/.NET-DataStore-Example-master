using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_categorysalesreport_pie_saleroom", DwStyle.Graph)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Categorysalesreport_Pie_Saleroom
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Productcategoryname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

    }

}
