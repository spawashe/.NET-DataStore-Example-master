using DWNet.Data;
using SnapObjects.Data;
using System;
using System.Collections.Generic;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_select_from_thru_date", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    [DwData(typeof(D_Select_From_Thru_Date_Data))]
    public class D_Select_From_Thru_Date
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Customer { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? From_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? To_Date { get; set; }

    }

    #region D_Select_From_Thru_Date_Data
    public class D_Select_From_Thru_Date_Data : DwDataInitializer<D_Select_From_Thru_Date>
    {
        public override IList<D_Select_From_Thru_Date> GetDefaultData()
        {
            var datas = new List<D_Select_From_Thru_Date>()
            { 
                 new D_Select_From_Thru_Date() { From_Date = null, To_Date = null },              
            };

            return datas;
        }
    }
    #endregion
}
