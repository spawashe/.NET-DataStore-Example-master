using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_order_header_free", DwStyle.Default)]
    [Table("SalesOrderHeader", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.SalesOrderHeader\" ) COLUMN(NAME=\"Sales.SalesOrderHeader.salesorderid\") COLUMN(NAME=\"Sales.SalesOrderHeader.revisionnumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.orderdate\") COLUMN(NAME=\"Sales.SalesOrderHeader.duedate\") COLUMN(NAME=\"Sales.SalesOrderHeader.shipdate\") COLUMN(NAME=\"Sales.SalesOrderHeader.status\") COLUMN(NAME=\"Sales.SalesOrderHeader.onlineorderflag\") COLUMN(NAME=\"Sales.SalesOrderHeader.salesordernumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.purchaseordernumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.accountnumber\") COLUMN(NAME=\"Sales.SalesOrderHeader.customerid\") COLUMN(NAME=\"Sales.SalesOrderHeader.salespersonid\") COLUMN(NAME=\"Sales.SalesOrderHeader.territoryid\") COLUMN(NAME=\"Sales.SalesOrderHeader.billtoaddressid\") COLUMN(NAME=\"Sales.SalesOrderHeader.shiptoaddressid\") COLUMN(NAME=\"Sales.SalesOrderHeader.shipmethodid\") COLUMN(NAME=\"Sales.SalesOrderHeader.creditcardid\") COLUMN(NAME=\"Sales.SalesOrderHeader.creditcardapprovalcode\") COLUMN(NAME=\"Sales.SalesOrderHeader.currencyrateid\") COLUMN(NAME=\"Sales.SalesOrderHeader.subtotal\") COLUMN(NAME=\"Sales.SalesOrderHeader.taxamt\") COLUMN(NAME=\"Sales.SalesOrderHeader.freight\") COLUMN(NAME=\"Sales.SalesOrderHeader.totaldue\") COLUMN(NAME=\"Sales.SalesOrderHeader.comment\") COLUMN(NAME=\"Sales.SalesOrderHeader.modifieddate\")WHERE(    EXP1 =\"Sales.SalesOrderHeader.SalesOrderID\"   OP =\"=\"    EXP2 =\":al_order_id\" ) ) ARG(NAME = \"al_order_id\" TYPE = number) ")]
    #endregion
    [DwParameter("al_order_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Order_Header_Free
    {
        [Identity]
        [Key]
        [DefaultValue("0")]
        public int Salesorderid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0))")]
        public Byte Revisionnumber { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Orderdate { get; set; }

        [ConcurrencyCheck]
        public DateTime Duedate { get; set; }

        [ConcurrencyCheck]
        public DateTime? Shipdate { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("1")]
        public Byte Status { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((1))")]
        public bool Onlineorderflag { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesordernumber { get; set; }

        [ConcurrencyCheck]
        public string Purchaseordernumber { get; set; }

        [ConcurrencyCheck]
        public string Accountnumber { get; set; }

        [ConcurrencyCheck]
        [DwChild("Customer_Customerid", "Full_Name", typeof(D_Dddw_Customer_Individual))]
        public int Customerid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Salesperson_Businessentityid", "Full_Name", typeof(D_Dddw_Salesperson))]
        public int? Salespersonid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Salesterritory_Territoryid", "Salesterritory_Name", typeof(D_Dddw_Salesterritory))]
        public int? Territoryid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        public int Billtoaddressid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Businessentityaddress_Addressid", "Address_Addressline1", typeof(D_Dddw_Customer_Address))]
        public int Shiptoaddressid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Shipmethodid", "Name", typeof(D_Dddw_Shipmethod))]
        public int Shipmethodid { get; set; }

        [ConcurrencyCheck]
        [DwChild("Creditcard_Creditcardid", "Creditcard_Cardnumber", typeof(D_Dddw_Customer_Creditcard))]
        public int? Creditcardid { get; set; }

        [ConcurrencyCheck]
        public string Creditcardapprovalcode { get; set; }

        [ConcurrencyCheck]
        public int? Currencyrateid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("0")]
        public decimal Subtotal { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("0")]
        public decimal Taxamt { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("0")]
        public decimal Freight { get; set; }

        [PropertySave(SaveStrategy.ReadAfterSave)]
        public decimal Totaldue { get; set; }

        [ConcurrencyCheck]
        public string Comment { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

    }

}
