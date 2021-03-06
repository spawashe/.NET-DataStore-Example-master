using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_person_list_compress", DwStyle.Grid)]
    [Table("Person", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Person.Person.businessentityid, " 
                  + "Person.Person.persontype, "
                  + "Person.Person.namestyle, "
                  + "Person.Person.title, "
                  + "Person.Person.firstname, "
                  + "Person.Person.middlename, "
                  + "Person.Person.lastname, "
                  + "Person.Person.suffix, "
                  + "Person.Person.emailpromotion, "
                  + "Person.Person.Demographics, "
                  + "Person.Person.modifieddate  , "
                  + "Person.Address.AddressLine1, "
                  + "Person.Address.City, "
                  + "Person.Address.rowguid "
                  + "FROM Person.Person , "
                  + "Person.BusinessEntityAddress, "
                  + "Person.Address "
                  + "Where (Person.Person.persontype = :personType or :personType = 'ALL') "
                  + "And (Person.Person.businessentityid = Person.BusinessEntityAddress.businessentityid) "
                  + "And (Person.BusinessEntityAddress.AddressId = Person.Address.AddressId)"
            )]
    #endregion
    [DwParameter("personType", typeof(string))]
    [DwSort("businessentityid A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Person_List_Compress
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Businessentityid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Persontype", "Typedesc", typeof(D_Dddw_Persontype))]
        public string Persontype { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public bool? Namestyle { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Firstname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Middlename { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Lastname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Suffix { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Emailpromotion { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Demographics { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public DateTime? Modifieddate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_Addressline1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Address_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public Guid Address_Rowguid { get; set; }

    }

}
