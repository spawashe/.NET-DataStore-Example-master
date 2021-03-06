using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_categorysalesreport_graph_saleroom", DwStyle.Graph)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Categorysalesreport_Graph_Saleroom
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Productcategoryname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsalesqty { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Totalsaleroom { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Year { get; set; }

    }

}
